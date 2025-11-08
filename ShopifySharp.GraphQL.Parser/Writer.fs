module ShopifySharp.GraphQL.Parser.Writer

open System
open System.IO
open System.IO.Pipelines
open System.Linq
open System.Text
open System.Threading.Tasks
open Microsoft.CodeAnalysis;
open Microsoft.CodeAnalysis.CSharp;
open Microsoft.CodeAnalysis.CSharp.Syntax
open ShopifySharp.GraphQL.Parser.PipeWriter
open Utils

type QueryBuilder<'t> = ShopifySharp.Infrastructure.Query<'t>

type private Writer = PipeWriter

let private (~%) job = ignore job

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

let private writeNamespaceAndUsings (writer: Writer) : ValueTask =
    pipeWriter writer {
        do! "#nullable enable"
        do! NewLine
        do! "namespace ShopifySharp.GraphQL;"
        do! NewLine
        do! "using System;"
        do! NewLine
        do! "using System.Threading.Tasks;"
        do! NewLine
        do! "using System.Text.Json.Serialization;"
        do! NewLine
        do! "using System.Collections.Generic;"
        do! NewLine
        do! "using ShopifySharp.Credentials;"
        do! NewLine
        do! "using ShopifySharp.Infrastructure;"
        do! NewLine
        do! "using ShopifySharp.Infrastructure.Serialization.Json;"
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

let private writeJsonPropertyAttribute (propertyName: string) writer : ValueTask =
    pipeWriter writer {
        do! (toTab Indented) + $"[JsonPropertyName(\"{propertyName}\")]"
        do! NewLine
    }

/// <summary>
/// Writes an attribute for deserializing the <see cref="DateOnly"/> data type in .NET Standard 2.0. Uses the
/// <see cref="Portable.System.DateTimeOnly.Json"/> package's <see cref="DateOnlyConverter"/> converter.
/// </summary>
let private writeDateOnlyJsonConverterAttribute (fieldType: FieldType) writer: ValueTask =
    let fieldValueType = AstNodeMapper.unwrapFieldType fieldType
    pipeWriter writer {
        if fieldValueType = FieldValueType.DateOnly then
            do! (toTab Indented) + "#if NETSTANDARD2_0"
            do! NewLine
            // This attribute comes from the Portable.System.DateTimeOnly.Json package
            do! (toTab Indented) + "[System.Text.Json.DateOnlyConverter]"
            do! NewLine
            do! (toTab Indented) + "#endif"
            do! NewLine
    }


let private writeGraphUnionTypeConverterAttribute unionTypeName writer: ValueTask =
    pipeWriter writer {
        do! $"[JsonConverter(typeof(GraphUnionTypeConverter<{unionTypeName}>))]"
        do! NewLine
    }

let private writeJsonDerivedTypeAttributes2 interfaceName (classNames: string[]) writer: ValueTask =
    pipeWriter writer {
        do! "[JsonPolymorphic(TypeDiscriminatorPropertyName = \"__typename\")]"
        do! NewLine

        for typeName in classNames do
            do! $"""[JsonDerivedType(typeof({typeName}), typeDiscriminator: "{typeName}")]"""
            do! NewLine
    }

let private getAppropriateClassTNodeTypeFromField (isNamedType: NamedType -> bool) assumeNullability fieldName (fields: Field[]) =
    fields
    |> Array.find _.Name.Equals(fieldName, StringComparison.OrdinalIgnoreCase)
    |> fun field -> AstNodeMapper.mapFieldTypeToString isNamedType assumeNullability field.ValueType UnwrapCollection

let private writeInheritedUnionCaseType (context: IParsedContext) (unionCaseName: string) writer: ValueTask =
    pipeWriter writer {
        // Union cases previously wrote both this interface type and their inherited union type. That does not work though,
        // as A) a union case can appear in more than one union (e.g. Metaobject was in MetaobjectReference and MetaobjectReferencer)
        // and B) it made it impossible to serialize the union case to json in cases where the union case had a property
        // chain that referenced its own union type parent (e.g. the Metaobject -> MetaobjectField -> MetaobjectReferencer -> Metaobject).
        do! "IGraphQLUnionCase"
    }

let private writeClassKnownInheritedType (context: IParsedContext) (class': Class) writer: ValueTask =
    let isNamedType = context.IsNamedType

    pipeWriter writer {
        if context.TypeIsKnownUnionCase class'.Name then
            yield! writeInheritedUnionCaseType context class'.Name
            do! ", "

        match class'.KnownInheritedType with
        | Some Edge ->
            let edgeNodeType = getAppropriateClassTNodeTypeFromField isNamedType context.AssumeNullability "Node" class'.Fields
            $"Edge<{edgeNodeType}>"
        | Some (Connection ConnectionType.Connection) ->
            "IConnection"
        | Some (Connection (ConnectionWithEdges _)) ->
            let edgesNodeType = getAppropriateClassTNodeTypeFromField isNamedType context.AssumeNullability "Edges" class'.Fields
            $"ConnectionWithEdges<{edgesNodeType}>"
        | Some (Connection (ConnectionWithNodes _)) ->
            let nodesNodeType = getAppropriateClassTNodeTypeFromField isNamedType context.AssumeNullability "Nodes" class'.Fields
            $"ConnectionWithNodes<{nodesNodeType}>"
        | Some (Connection (ConnectionWithNodesAndEdges _)) ->
            let nodesNodeType = getAppropriateClassTNodeTypeFromField isNamedType context.AssumeNullability "Nodes" class'.Fields
            $"ConnectionWithNodesAndEdges<{nodesNodeType}>"
        | None ->
            "IGraphQLObject"
    }

/// Joins the type names with a comma and writes them to the PipeWriter. Intended for writing a list of inherited
/// types or the generic types in `GraphQLUnionType<T1, T2>`
let private writeJoinedTypeNames (typeNames: string[]) writer: ValueTask =
    pipeWriter writer {
        do! String.Join(", ", typeNames)
    }

let private shouldSkipField parentKnownInheritedType (field: Field): bool =
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
        let totalCountFieldName = "TotalCount"

        let pageInfoFieldMatches = fieldName.Equals(pageInfoFieldName, comparison)
        let nodesFieldMatches = fieldName.Equals(nodesFieldName, comparison)
        let edgesFieldMatches = fieldName.Equals(edgesFieldName, comparison)
        let totalCountFieldMatches = fieldName.Equals(totalCountFieldName, comparison)

        // All connection field types have a PageInfo and TotalCount field
        if pageInfoFieldMatches || totalCountFieldMatches then
            true
        else
            match connectionType with
            | ConnectionType.Connection ->
                false
            | ConnectionWithNodes _ ->
                nodesFieldMatches
            | ConnectionWithEdges _ ->
                edgesFieldMatches
            | ConnectionWithNodesAndEdges _ ->
                nodesFieldMatches || edgesFieldMatches

let rec private writeDefaultValueForFieldType fieldType assumeNullable writer =
    pipeWriter writer {
        // Write a null or default value for the class types to satisfy nullable compiler warnings
        match fieldType, assumeNullable with
        | NullableType _, _
        | _, true ->
            do! " = null;"
        | NonNullableType (CollectionType _), false
        | CollectionType _, false ->
            do! " = [];"
        | NonNullableType (ValueType FieldValueType.Boolean), false
        | ValueType FieldValueType.Boolean, false ->
            do! " = false;"
        | NonNullableType (ValueType (FieldValueType.GraphObjectType _)), false
        | ValueType (FieldValueType.GraphObjectType _), false ->
            do! " = default;"
        | NonNullableType _, false
        | ValueType _, false ->
            do! " = default;"
    }

let private writeFields (context: IParsedContext) shouldSkipWritingField parentType (fields: Field[]) writer : ValueTask =
    // Filter out the Cursor and Node fields for any class that inherits the Edge<TNode> type
    let writeableFields =
        fields
        |> Seq.filter (shouldSkipWritingField >> not)

    pipeWriter writer {
        for field in writeableFields do
            let fieldType = AstNodeMapper.mapFieldTypeToString context.IsNamedType context.AssumeNullability field.ValueType KeepCollection

            yield! writeSummary Indented field.XmlSummary
            yield! writeJsonPropertyAttribute field.Name
            yield! writeDateOnlyJsonConverterAttribute field.ValueType
            yield! writeDeprecationAttribute Indented field.Deprecation

            let fieldName =
                toCasing context.CasingType field.Name
                |> sanitizeFieldOrOperationName parentType

            do! (toTab Indented) + $$"""public {{fieldType}} {{fieldName}} { get; set; }"""

            match parentType with
            | NamedType.Interface _ ->
                ()
            | NamedType.Class _
            | NamedType.InputObject _ ->
                yield! writeDefaultValueForFieldType field.ValueType context.AssumeNullability
            | NamedType.Enum p
            | NamedType.UnionType p ->
                failwith $"Parent \"{p}\" is unsupported type {parentType.GetType()}"

            do! NewLine
    }

let private writeClass (class': Class) (context: IParsedContext) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented class'.XmlSummary
        yield! writeDeprecationAttribute Outdented class'.Deprecation

        do! $"public record {class'.Name}: "

        yield! writeClassKnownInheritedType context class'

        if Array.length class'.InheritedTypeNames > 0 then
            do! ", "
            yield! writeJoinedTypeNames class'.InheritedTypeNames

        do! NewLine
        do! "{"
        do! NewLine

        yield! writeFields context (shouldSkipField class'.KnownInheritedType) (NamedType.Class class'.Name) class'.Fields

        do! "}"
        do! NewLine
    }

let private writeInterface (interface': Interface) (context: IParsedContext) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented interface'.XmlSummary
        yield! writeDeprecationAttribute Outdented interface'.Deprecation
        yield! writeJsonDerivedTypeAttributes2 interface'.Name (context.GetInterfaceImplementationTypeNames interface'.Name)

        do! $"public interface {interface'.Name}: IGraphQLObject"

        if Array.length interface'.InheritedTypeNames > 0 then
            do! ", "
            yield! writeJoinedTypeNames interface'.InheritedTypeNames

        if context.TypeIsKnownUnionCase interface'.Name then
            do! ", "
            yield! writeInheritedUnionCaseType context interface'.Name

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
            yield! writeInheritedUnionCaseType context enum.Name

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
            yield! writeInheritedUnionCaseType context inputObject.Name

        do! NewLine
        do! "{"
        do! NewLine

        yield! writeFields context (shouldSkipField None) (NamedType.InputObject inputObject.Name) inputObject.Fields

        do! "}"
        do! NewLine
    }

let private writeUnionCaseWrappers (unionType: UnionType) (writer: Writer): ValueTask =
    pipeWriter writer {
        for unionCase in unionType.Cases do
            let caseWrapperName = toUnionCaseWrapperName unionType.Name unionCase.Name
            do! $"internal record {caseWrapperName}({unionCase.Name} Value): {unionType.Name};"
            do! NewLine
    }

/// <summary>
/// Maps the union type's case names to public type methods, each using the internal union case wrapper types.
/// <example>
/// <code>
///	public MoneyV2? AsMoneyV2() => this is DeliveryConditionCriteriaMoneyV2 wrapper ? wrapper.Value : null;
///	public Weight? AsWeight() => this is DeliveryConditionCriteriaWeight wrapper ? wrapper.Value : null;
/// </code>
/// </example>
/// </summary>
let private writeUnionTypeConversionMethods (unionType: UnionType) writer: ValueTask =
    pipeWriter writer {
        for unionCase in unionType.Cases do
            let caseWrapperName = toUnionCaseWrapperName unionType.Name unionCase.Name
            do! (toTab Indented) + $"public {unionCase.Name}? As{unionCase.Name}() => this is {caseWrapperName} wrapper ? wrapper.Value : null;"
            do! NewLine
    }

let private writeUnionType (unionType: UnionType) (_: IParsedContext) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented unionType.XmlSummary
        yield! writeDeprecationAttribute Outdented unionType.Deprecation
        yield! writeGraphUnionTypeConverterAttribute unionType.Name

        do! $"public record {unionType.Name}: GraphQLObject<{unionType.Name}>, IGraphQLUnionType"

        do! NewLine
        do! "{"
        do! NewLine

        yield! writeUnionTypeConversionMethods unionType

        do! NewLine
        do! "}"
        do! NewLine

        yield! writeUnionCaseWrappers unionType
    }

let private shouldSkipType (visitedType: VisitedTypes): bool =
    let typeNamesToSkip = Set.ofList [
        "Node"; "INode"
        "PageInfo"
    ]

    Set.contains visitedType.Name typeNamesToSkip

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
                | VisitedTypes.Class class' ->
                    yield! writeClass class' parsedContext
                | VisitedTypes.Interface interface' ->
                    yield! writeInterface interface' parsedContext
                | VisitedTypes.Enum enum' ->
                    yield! writeEnum enum' parsedContext
                | VisitedTypes.InputObject inputObject ->
                    yield! writeInputObject inputObject parsedContext
                | VisitedTypes.UnionType unionType ->
                    yield! writeUnionType unionType parsedContext
                | VisitedTypes.Operation _ ->
                    ()
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

let writeServicesToFileSystem(destination: FileSystemDestination) (context: ParserContext): ValueTask =
    let cancellationToken = context.CancellationToken

    ValueTask(task {
        let pipe = Pipe(PipeOptions())
        let readTask = (readPipe pipe.Reader cancellationToken).ConfigureAwait(false)

        do! QueryBuilderWriter.writeServicesToPipe context pipe.Writer
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
