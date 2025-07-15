module ShopifySharp.GraphQL.ParserF.Writer

open System
open System.IO
open System.IO.Pipelines
open System.Linq
open System.Text
open System.Threading.Tasks
open Microsoft.CodeAnalysis;
open Microsoft.CodeAnalysis.CSharp;
open Microsoft.CodeAnalysis.CSharp.Syntax
open ShopifySharp.GraphQL.ParserF.PipeWriter;

type private Writer = PipeWriter

let private (~%) job = ignore job

let private NewLine = Environment.NewLine

let private toTab = function
    | Indented -> "\t"
    | Outdented -> String.Empty

let private parseCsharpStringToGeneratedFiles (csharpCode: string) cancellationToken: ValueTask<GeneratedCsharpFile[]> =
    ValueTask<GeneratedCsharpFile[]>(task {
        let! csharpTree = CSharpSyntaxTree.ParseText(csharpCode).GetRootAsync(cancellationToken)
        let syntaxRoot = csharpTree :?> CompilationUnitSyntax;
        let usings = syntaxRoot.Usings;
        let externals = syntaxRoot.Externs

        let rootMembers = syntaxRoot.Members |> Array.ofSeq
        let rootTypes = rootMembers |> Array.filter (fun m -> m :? BaseTypeDeclarationSyntax)

        let namespaces = syntaxRoot.Members.OfType<BaseNamespaceDeclarationSyntax>() |> Array.ofSeq
        let fileScopedNamespaces = syntaxRoot.Members.OfType<FileScopedNamespaceDeclarationSyntax>() |> Array.ofSeq

        let allTypes =
            if fileScopedNamespaces.Length > 0 then
                // Handle file-scoped namespaces - collect ALL types (both from namespace and root)
                let nsTypes =
                    fileScopedNamespaces
                    |> Array.collect (fun ns ->
                        let types = ns.Members.OfType<BaseTypeDeclarationSyntax>() |> Array.ofSeq
                        types |> Array.map (fun t -> (ns :> BaseNamespaceDeclarationSyntax, t)))

                // Also collect types that ended up at root level due to parsing issues
                let rootLevelTypes = rootTypes |> Array.map (fun t ->
                    // Use the file-scoped namespace for root-level types
                    (fileScopedNamespaces[0] :> BaseNamespaceDeclarationSyntax, t :?> BaseTypeDeclarationSyntax))
                Array.concat [nsTypes; rootLevelTypes]
            else
                // Handle regular namespaces
                namespaces
                |> Array.collect (fun ns ->
                    let types = ns.Members.OfType<BaseTypeDeclarationSyntax>() |> Array.ofSeq
                    types |> Array.map (fun t -> (ns, t)))

        return
            allTypes
            |> Array.map (fun (ns, type') ->
                let unit = SyntaxFactory.CompilationUnit()
                            .WithExterns(externals)
                            .WithUsings(usings)
                            .AddMembers(ns.WithMembers(SyntaxFactory.SingletonList<MemberDeclarationSyntax>(type')))
                            .NormalizeWhitespace(eol = Environment.NewLine)

                { FileName = type'.Identifier.Text + ".cs"
                  FileText = unit.ToFullString() }
            )
    })

let private writeFileToPath filePath (fileText: string) cancellationToken: ValueTask =
    ValueTask(task {
        if File.Exists(filePath) then
            File.Delete(filePath)

        let directory = Path.GetDirectoryName filePath

        if directory <> "" && not (Directory.Exists directory) then
            %Directory.CreateDirectory(directory)

        do! File.WriteAllTextAsync(filePath, fileText, cancellationToken)
    })

let private parseCsharpCodeAndWriteToDirectoryPath directoryPath (csharpCode: StringBuilder) cancellationToken =
    ValueTask(task {
        let! generatedFiles = parseCsharpStringToGeneratedFiles (csharpCode.ToString()) cancellationToken
        for file in generatedFiles do
            let filePath = Path.Join(directoryPath, "/", file.FileName)
            do! writeFileToPath filePath file.FileText cancellationToken
    })

let private readPipe (reader: PipeReader) cancellationToken: ValueTask<StringBuilder> =
    let sb = StringBuilder()
    let rec loop () = task {
        let! result = reader.ReadAsync(cancellationToken).ConfigureAwait(false)

        let mutable enumerator = result.Buffer.GetEnumerator()
        while enumerator.MoveNext() do
            %sb.Append(Encoding.UTF8.GetString(enumerator.Current.Span))

        reader.AdvanceTo(result.Buffer.End)

        if not (result.IsCompleted || result.IsCanceled) then
            do! loop()
    }

    ValueTask<StringBuilder>(task {
        do! loop()
        do! reader.CompleteAsync().ConfigureAwait(false)
        return sb
    })

let private sanitizeString (str: string): string =
    str.ReplaceLineEndings("")
       .Replace("\"", "", StringComparison.OrdinalIgnoreCase)
       .Replace("'", "", StringComparison.OrdinalIgnoreCase)

let private csharpKeywords = Set.ofList [
    "abstract"; "as"; "base"; "bool"; "break"; "byte"; "case"; "catch"; "char"; "checked";
    "class"; "const"; "continue"; "decimal"; "default"; "delegate"; "do"; "double"; "else";
    "enum"; "event"; "explicit"; "extern"; "false"; "finally"; "fixed"; "float"; "for";
    "foreach"; "goto"; "if"; "implicit"; "in"; "int"; "interface"; "internal"; "is"; "lock";
    "long"; "namespace"; "new"; "null"; "object"; "operator"; "out"; "override"; "params";
    "private"; "protected"; "public"; "readonly"; "ref"; "return"; "sbyte"; "sealed";
    "short"; "sizeof"; "stackalloc"; "static"; "string"; "struct"; "switch"; "this";
    "throw"; "true"; "try"; "typeof"; "uint"; "ulong"; "unchecked"; "unsafe"; "ushort";
    "using"; "virtual"; "void"; "volatile"; "while";
    // Contextual keywords that can also cause issues
    "add"; "alias"; "ascending"; "async"; "await"; "by"; "descending"; "dynamic"; "equals";
    "from"; "get"; "global"; "group"; "into"; "join"; "let"; "nameof"; "orderby"; "partial";
    "remove"; "select"; "set"; "value"; "var"; "when"; "where"; "yield"
]

/// <summary>
/// Sanitizes the value, replacing reserved C# keywords with <c>$"@{value}"</c>
/// </summary>
let private sanitizeFieldName (parentType: NamedType) (fieldName: string): string =
    if fieldName.Equals(parentType.ToString(), StringComparison.OrdinalIgnoreCase) then
        // The C# compiler will not allow the @ prefix for members that have the same name as their enclosing type
        fieldName + "_"
    elif Set.contains fieldName csharpKeywords then
        "@" + fieldName
    else
        fieldName

let private toCasing casing (str: string): string =
    let first = str[0]
    let rest  = str[1..]
    match casing with
    | Pascal -> Char.ToUpper(first).ToString() + rest
    | Camel -> Char.ToLower(first).ToString() + rest

let private mapStrToInterfaceName =
    sprintf "I%s"

let private mapValueTypeToString (isNamedType: NamedType -> bool) = function
    | FieldValueType.ULong -> "ulong"
    | FieldValueType.Long -> "long"
    | FieldValueType.Int -> "int"
    | FieldValueType.Decimal -> "decimal"
    | FieldValueType.Float -> "float"
    | FieldValueType.Boolean -> "bool"
    | FieldValueType.String -> "string"
    | FieldValueType.DateTime -> "DateTime"
    | FieldValueType.DateOnly -> "DateOnly"
    | FieldValueType.TimeSpan -> "TimeSpan"
    | FieldValueType.GraphObjectType graphObjectTypeName ->
        if isNamedType (NamedType.Interface graphObjectTypeName)
        then mapStrToInterfaceName graphObjectTypeName
        else graphObjectTypeName

let rec private mapFieldTypeToString (isNamedType: NamedType -> bool) (valueType: FieldType) (collectionHandling: FieldTypeCollectionHandling) =
    match valueType with
    | ValueType valueType -> mapValueTypeToString isNamedType valueType
    | NonNullableType nonNullableType -> mapFieldTypeToString isNamedType nonNullableType collectionHandling
    | NullableType nullableType -> $"{mapFieldTypeToString isNamedType nullableType collectionHandling}?"
    | CollectionType collectionType ->
        let mappedType = mapFieldTypeToString isNamedType collectionType collectionHandling
        match collectionHandling with
        | KeepCollection -> $"ICollection<{mappedType}>"
        | UnwrapCollection -> mappedType

let private writeNamespaceAndUsings (writer: Writer) : ValueTask =
    pipeWriter writer {
        do! "#nullable enable"
        do! NewLine
        do! NewLine
        do! "namespace ShopifySharp.GraphQL;"
        do! NewLine
        do! "using System;"
        do! NewLine
        do! "using System.Text.Json.Serialization;"
        do! NewLine
        do! "using System.Collections.Generic;"
        do! NewLine
    }

let private writeSummary  indentation (summary: string[]) writer : ValueTask =
    let indentation = toTab indentation
    pipeWriter writer {
        for line in summary do
            do! indentation
            do! line
            do! NewLine
    }

let private writeDeprecationAttribute indentation (deprecationWarning: string option) writer : ValueTask =
    let indentation = toTab indentation
    pipeWriter writer {
        match deprecationWarning with
        | Some x when String.IsNullOrWhiteSpace x ->
            do! indentation
            do! "[Obsolete]"
            do! NewLine
        | Some x ->
            do! indentation
            do! $"[Obsolete(\"{sanitizeString x}\")]"
            do! NewLine
        | None ->
            ()
    }

let private writeJsonPropertyAttribute (propertyName: string) writer : ValueTask =
    pipeWriter writer {
        do! (toTab Indented) + $"[JsonPropertyName(\"{propertyName}\")]"
        do! NewLine
    }

let private writeJsonDerivedTypeAttributes (typeNames: string[]) writer: ValueTask =
    pipeWriter writer {
        do! "[JsonPolymorphic(TypeDiscriminatorPropertyName = \"__typename\")]"
        do! NewLine

        for typeName in typeNames do
            do! $"""[JsonDerivedType(typeof({typeName}), typeDiscriminator: "{typeName}")]"""
            do! NewLine
    }

let appendINodeInheritedTypeIfAppropriate (inheritedTypeNames: string[]) (fields: Field[]) =
    let comparison = StringComparison.OrdinalIgnoreCase
    let isNodeInterface (typeName: string) =
        typeName.Equals("Node", comparison) || typeName.Equals("INode", comparison)
    let isIdField (field: Field) =
        field.Name.Equals("Id", comparison)

    if Array.exists isNodeInterface inheritedTypeNames then
        inheritedTypeNames
    else if not (Array.exists isIdField fields) then
        inheritedTypeNames
    else
        Array.append [|"INode"|] inheritedTypeNames

let private getAppropriateClassTNodeTypeFromField (isNamedType: NamedType -> bool) fieldName (fields: Field[]) =
    fields
    |> Array.find _.Name.Equals(fieldName, StringComparison.OrdinalIgnoreCase)
    |> fun field -> mapFieldTypeToString isNamedType field.ValueType UnwrapCollection

let private writeClassKnownInheritedType (isNamedType: NamedType -> bool) (class': Class) writer: ValueTask =
    let className = class'.Name
    pipeWriter writer {
        match class'.KnownInheritedType with
        | Some Edge ->
            let edgeNodeType = getAppropriateClassTNodeTypeFromField isNamedType "Node" class'.Fields
            $"Edge<{edgeNodeType}>"
        | Some (Connection ConnectionType.Connection) ->
            "IConnection"
        | Some (Connection (ConnectionWithEdges _)) ->
            let edgesNodeType = getAppropriateClassTNodeTypeFromField isNamedType "Edges" class'.Fields
            $"ConnectionWithEdges<{edgesNodeType}>"
        | Some (Connection (ConnectionWithNodes _)) ->
            let nodesNodeType = getAppropriateClassTNodeTypeFromField isNamedType "Nodes" class'.Fields
            $"ConnectionWithNodes<{nodesNodeType}>"
        | Some (Connection (ConnectionWithNodesAndEdges _)) ->
            let nodesNodeType = getAppropriateClassTNodeTypeFromField isNamedType "Nodes" class'.Fields
            $"ConnectionWithNodesAndEdges<{nodesNodeType}>"
        | None ->
            $"GraphQLObject<{className}>"
    }

let private writeInheritedUnionCaseType writer: ValueTask =
    pipeWriter writer {
        do! "IGraphQLUnionCase"
    }

/// Joins the type names with a comma and writes them to the PipeWriter. Intended for writing a list of inherited
/// types or the generic types in `GraphQLUnionType<T1, T2>`
let private writeJoinedTypeNames (typeNames: string[]) writer: ValueTask =
    pipeWriter writer {
        do! String.Join(", ", typeNames)
    }

let shouldSkipField parentKnownInheritedType (field: Field): bool =
    let fieldName = field.Name
    let comparison = StringComparison.OrdinalIgnoreCase
    match parentKnownInheritedType with
    | None ->
        false
    | Some Edge ->
        let edgeCursorFieldName = "Cursor"
        let nodeCursorFieldName = "Node"
        edgeCursorFieldName.Equals(fieldName, comparison) || nodeCursorFieldName.Equals(fieldName, comparison)
    | Some (Connection connectionType) ->
        let pageInfoFieldName = "PageInfo"
        let nodesFieldName = "Nodes"
        let edgesFieldName = "Edges"

        let pageInfoFieldMatches = fieldName.Equals(pageInfoFieldName, comparison)
        let nodesFieldMatches = fieldName.Equals(nodesFieldName, comparison)
        let edgesFieldMatches = fieldName.Equals(edgesFieldName, comparison)

        match connectionType with
        | ConnectionType.Connection ->
            pageInfoFieldMatches
        | ConnectionWithNodes _ ->
            pageInfoFieldMatches || nodesFieldMatches
        | ConnectionWithEdges _ ->
            pageInfoFieldMatches || edgesFieldMatches
        | ConnectionWithNodesAndEdges _ ->
            pageInfoFieldMatches || nodesFieldMatches || edgesFieldMatches

let private writeFields (context: IParsedContext) shouldSkipWritingField parentType (fields: Field[]) writer : ValueTask =
    // Filter out the Cursor and Node fields for any class that inherits the Edge<TNode> type
    let writeableFields =
        fields
        |> Seq.filter (shouldSkipWritingField >> not)

    pipeWriter writer {
        for field in writeableFields do
            let fieldType = mapFieldTypeToString context.IsNamedType field.ValueType KeepCollection

            yield! writeSummary Indented field.XmlSummary
            yield! writeJsonPropertyAttribute field.Name
            yield! writeDeprecationAttribute Indented field.Deprecation

            let fieldName =
                toCasing context.CasingType field.Name
                |> sanitizeFieldName parentType

            do! (toTab Indented) + $$"""public {{fieldType}} {{fieldName}} { get; set; }"""
            do! NewLine
    }

let private writeClass (class': Class) (context: IParsedContext) (writer: Writer): ValueTask =
    let inheritedTypes = appendINodeInheritedTypeIfAppropriate class'.InheritedTypeNames class'.Fields

    pipeWriter writer {
        yield! writeSummary Outdented class'.XmlSummary
        yield! writeDeprecationAttribute Outdented class'.Deprecation

        do! $"public record {class'.Name}: "
        yield! writeClassKnownInheritedType context.IsNamedType class'

        if Array.length inheritedTypes > 0 then
            do! ", "
            yield! writeJoinedTypeNames inheritedTypes

        if context.TypeIsKnownUnionCase class'.Name then
            do! ","
            yield! writeInheritedUnionCaseType

        do! NewLine
        do! "{"
        do! NewLine

        yield! writeFields context (shouldSkipField class'.KnownInheritedType) (NamedType.Class class'.Name) class'.Fields

        do! "}"
        do! NewLine
    }

let private writeInterface (interface': Interface) (context: IParsedContext) (writer: Writer): ValueTask =
    let inheritedTypes = appendINodeInheritedTypeIfAppropriate interface'.InheritedTypeNames interface'.Fields

    pipeWriter writer {
        yield! writeSummary Outdented interface'.XmlSummary
        yield! writeDeprecationAttribute Outdented interface'.Deprecation

        do! $"public interface {interface'.Name}: IGraphQLObject"

        if Array.length inheritedTypes > 0 then
            do! ", "
            yield! writeJoinedTypeNames inheritedTypes

        if context.TypeIsKnownUnionCase interface'.Name then
            do! ","
            yield! writeInheritedUnionCaseType

        do! NewLine
        do! "{"
        do! NewLine

        yield! writeFields context (shouldSkipField None) (NamedType.Interface interface'.Name) interface'.Fields

        do! "}"
        do! NewLine
    }

let private writeEnum (enum: VisitedEnum) (context: IParsedContext) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented enum.XmlSummary
        yield! writeDeprecationAttribute Outdented enum.Deprecation

        do! $"public enum {enum.Name}"

        // This is invalid C# code, but we write it anyway so the compiler will throw an error and alert us of an
        // incompatible GraphQL type
        if context.TypeIsKnownUnionCase enum.Name then
            do! ": "
            yield! writeInheritedUnionCaseType

        do! NewLine
        do! "{"
        do! NewLine

        for case in enum.Cases do
            yield! writeDeprecationAttribute Outdented case.Deprecation

            do! (toTab Indented) + case.Name
            if Option.isSome case.Value then
                do! " = " + (Option.get case.Value)
            do! ","
            do! NewLine

        do! "}"
        do! NewLine
    }

let private writeInputObject (inputObject: InputObject) (context: IParsedContext) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented inputObject.XmlSummary
        yield! writeDeprecationAttribute Outdented inputObject.Deprecation

        do! $"public record {inputObject.Name}: GraphQLInputObject<{inputObject.Name}>"

        if context.TypeIsKnownUnionCase inputObject.Name then
            do! ", "
            yield! writeInheritedUnionCaseType

        do! NewLine
        do! "{"
        do! NewLine

        yield! writeFields context (shouldSkipField None) (NamedType.InputObject inputObject.Name) inputObject.Fields

        do! "}"
        do! NewLine
    }

let private writeUnionType (unionType: UnionType) (_: IParsedContext) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented unionType.XmlSummary
        yield! writeDeprecationAttribute Outdented unionType.Deprecation
        yield! writeJsonDerivedTypeAttributes unionType.Types

        do! $"public record {unionType.Name}: IGraphQLUnionType"

        do! NewLine
        do! "{"
        do! NewLine

        // These default interface methods are only usable in .NET 6.0 and above - anything lower will cause
        // the compiler to throw an error.
        do! "#if NET6_0_OR_GREATER"
        do! NewLine

        for typeName in unionType.Types do
            do! (toTab Indented) + $"public {typeName}? As{typeName}() => this as {typeName};"
            do! NewLine

        do! "#endif"
        do! NewLine
        do! "}"
        do! NewLine
    }

let private shouldSkipType visitedType: bool =
    let typeNamesToSkip = Set.ofList [
        "Node"; "INode"
        "PageInfo"
    ]
    let typeName =
        match visitedType with
        | Class class' -> class'.Name
        | Interface interface' -> interface'.Name
        | Enum enum' -> enum'.Name
        | InputObject inputObject -> inputObject.Name
        | UnionType unionType -> unionType.Name
    Set.contains typeName typeNamesToSkip

let private writeVisitedTypesToPipe (writer: Writer) (context: ParserContext): ValueTask =
    let parsedContext = context :> IParsedContext

    pipeWriter writer {
        // Always write the namespace and usings at the very top of the document
        yield! writeNamespaceAndUsings

        for visitedType in context.VisitedTypes do
            if shouldSkipType visitedType then
                ()
            else
                match visitedType with
                | Class class' ->
                    yield! writeClass class' parsedContext
                | Interface interface' ->
                    yield! writeInterface interface' parsedContext
                | Enum enum' ->
                    yield! writeEnum enum' parsedContext
                | InputObject inputObject ->
                    yield! writeInputObject inputObject parsedContext
                | UnionType unionType ->
                    yield! writeUnionType unionType parsedContext
    }

let writeVisitedTypesToFileSystem (destination: FileSystemDestination) (context: ParserContext) : ValueTask =
    let cancellationToken = context.CancellationToken

    ValueTask(task {
        let pipe = Pipe(PipeOptions())
        let readTask = (readPipe pipe.Reader cancellationToken).ConfigureAwait(false)

        do! writeVisitedTypesToPipe pipe.Writer context
        do! pipe.Writer.CompleteAsync().ConfigureAwait(false);

        let! csharpCode = readTask

        match destination with
        | SingleFile filePath ->
            do! writeFileToPath filePath (csharpCode.ToString()) cancellationToken
        | Directory directoryPath ->
            do! parseCsharpCodeAndWriteToDirectoryPath directoryPath csharpCode cancellationToken
        | DirectoryAndTemporaryFile(directoryPath, temporaryFilePath) ->
            do! writeFileToPath temporaryFilePath (csharpCode.ToString()) cancellationToken
            do! parseCsharpCodeAndWriteToDirectoryPath directoryPath csharpCode cancellationToken
    })
