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

type QueryBuilder<'t> = ShopifySharp.Infrastructure.Query<'t>

type private Writer = PipeWriter

let private (~%) job = ignore job

let private NewLine = Environment.NewLine

let private toTab (indentation: Indentation) =
    indentation.ToString()

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
let private sanitizeFieldOrOperationName (parentType: NamedType) (fieldName: string): string =
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

let private toUnionCaseWrapperName unionTypeName unionCaseName =
    unionTypeName + unionCaseName

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

let rec private unwrapFieldType  = function
    | ValueType valueType -> valueType
    | NullableType valueType -> unwrapFieldType valueType
    | NonNullableType valueType -> unwrapFieldType valueType
    | CollectionType collectionType -> unwrapFieldType collectionType

let rec private mapFieldTypeToString (isNamedType: NamedType -> bool) assumeNullability (valueType: FieldType) (collectionHandling: FieldTypeCollectionHandling) =
    let maybeWriteNullability isNullable fieldStr =
        fieldStr + (if isNullable then "?" else "")

    let rec unwrapType isRecursing = function
        | ValueType valueType
        | NonNullableType (ValueType valueType) ->
            mapValueTypeToString isNamedType valueType
            |> maybeWriteNullability (not isRecursing && assumeNullability)
        | NullableType (ValueType valueType) ->
            mapValueTypeToString isNamedType valueType
            |> maybeWriteNullability true
        | NonNullableType (CollectionType collectionType) // We unwrap this one twice because CollectionTypes are all (NonNullable (CollectionType Type)) in GraphQL
        | CollectionType collectionType ->
            let mappedType = unwrapType true collectionType
            match collectionHandling with
            | KeepCollection -> $"ICollection<{mappedType}>"
            | UnwrapCollection -> mappedType
            |> maybeWriteNullability (not isRecursing && assumeNullability)
        | NonNullableType nonNullableType ->
            unwrapType true nonNullableType
        | NullableType nullableType ->
            unwrapFieldType nullableType
            |> mapValueTypeToString isNamedType
            |> maybeWriteNullability true

    unwrapType false valueType

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

/// <summary>
/// Writes an attribute for deserializing the <see cref="DateOnly"/> data type in .NET Standard 2.0. Uses the
/// <see cref="Portable.System.DateTimeOnly.Json"/> package's <see cref="DateOnlyConverter"/> converter.
/// </summary>
let private writeDateOnlyJsonConverterAttribute (fieldType: FieldType) writer: ValueTask =
    let fieldValueType = unwrapFieldType fieldType
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
    |> fun field -> mapFieldTypeToString isNamedType assumeNullability field.ValueType UnwrapCollection

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
            let fieldType = mapFieldTypeToString context.IsNamedType context.AssumeNullability field.ValueType KeepCollection

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

let writeUnionTypeMutationJoins (unionType: UnionType) (context: IParsedContext) writer: ValueTask =
    pipeWriter writer {
        for unionCase in unionType.Cases do
            let pascalUnionCaseName = toCasing Pascal unionCase.Name
            let camelUnionCaseName = toCasing Camel unionCase.Name
            let unionCaseQueryBuilderName = $"{pascalUnionCaseName}QueryBuilder"

            // TODO: write a {UnionCaseName}QueryBuilder class for every union case, to be used in these AddUnion and AddField methods

            do! Indented + $"public void AddUnion{pascalUnionCaseName}(Func<{unionCaseQueryBuilderName}, {unionCaseQueryBuilderName}> build)"
            do! NewLine
            do! Indented + "{"
            do! NewLine
            do! DoubleIndented + $"base.AddUnion<{pascalUnionCaseName}>(\"{unionCase.Name}\", build);"
            do! NewLine
            do! DoubleIndented + "return this;"
            do! NewLine
            do! Indented + "}"
            do! NewLine
    }

let writeQueryBuilderAddFieldMethods (pascalClassName: string) (operation: QueryOrMutation) (context: IParsedContext) writer: ValueTask =
    pipeWriter writer {
        match operation.ReturnType with
        | ReturnType.FieldType _ ->
            // TODO: This is probably where we just AddField("fieldName"), and ReturnType.VisitedType is where we AddField("fieldName", Func<IQuery<T>, IQuery<T>>)
            ()
        | ReturnType.VisitedType (VisitedTypes.UnionType unionType) ->
            printfn $"Operation {operation.Name} has union return type {unionType.Name}"
            yield! writeUnionTypeMutationJoins unionType context
        | ReturnType.VisitedType visitedType ->
            let fields =
                match visitedType with
                | VisitedTypes.Class class' ->
                    class'.Fields
                | VisitedTypes.Interface interface' ->
                    interface'.Fields
                | VisitedTypes.InputObject inputObject ->
                    inputObject.Fields
                | _ ->
                    failwith $"The VisitedType %A{visitedType.Name} is not supported here."

            for field in fields do
                let pascalFieldName = toCasing Pascal field.Name
                let camelFieldName = toCasing Camel field.Name

                // TODO: check if field.Type is a union type – if so, use AddUnion<TUnion>?

                // TODO: add the Func<IQuery<T>, IQuery<T>> overload

                yield! writeDeprecationAttribute Indented field.Deprecation
                do! Indented + $"public {pascalClassName} AddField{pascalFieldName}()"
                do! NewLine
                do! DoubleIndented + "{"
                do! NewLine
                do! DoubleIndented + $"Query = Query.AddField(\"{field.Name}\");"
                do! NewLine
                do! TripleIndented + "return this;"
                do! NewLine
                do! DoubleIndented + "}"
                do! NewLine
    }

let writeQueryBuilderAddArgumentMethods (pascalClassName: string) (operation: QueryOrMutation) (context: IParsedContext) writer: ValueTask =
    pipeWriter writer {
        let sanitizeArgumentName casing argName =
            sanitizeFieldOrOperationName (NamedType.Class pascalClassName) argName
            |> toCasing casing

        for argument in operation.Arguments do
            let valueType =
                mapFieldTypeToString context.IsNamedType context.AssumeNullability argument.ValueType FieldTypeCollectionHandling.KeepCollection
            let camelArgumentName =
                sanitizeArgumentName Camel argument.Name
            let pascalArgumentName =
                sanitizeArgumentName Pascal argument.Name

            yield! writeDeprecationAttribute Indented argument.Deprecation
            do! $"public {pascalClassName} AddArgument{pascalArgumentName}({valueType} {camelArgumentName})"
            do! NewLine
            do! DoubleIndented + "{"
            do! NewLine
            do! DoubleIndented + $"Query = Query.AddArgument(\"{argument.Name}\", {camelArgumentName});"
            do! NewLine
            do! TripleIndented + "return this;"
            do! NewLine
            do! DoubleIndented + "}"
            do! NewLine
    }

let writeQueryOrMutationServices (queryOrMutation: QueryOrMutation) (context: IParsedContext) writer: ValueTask =
    pipeWriter writer {
        // TODO: handle all of the query and mutation operations at once, then categorize them by their "entity type"
        //       (e.g. orders go into a GraphOrderService).
        let pascalClassName = toCasing Pascal (queryOrMutation.Name + "Service")
        let camelClassName = toCasing Camel pascalClassName
        let returnType = queryOrMutation.ReturnType

        let methodReturnType =
            match returnType with
            | ReturnType.VisitedType visitedTypes ->
                visitedTypes.Name
            | ReturnType.FieldType fieldType ->
                mapFieldTypeToString context.IsNamedType context.AssumeNullability fieldType FieldTypeCollectionHandling.KeepCollection

        yield! writeDeprecationAttribute Indented queryOrMutation.Deprecation

        do! $"public class {pascalClassName}(): GraphQueryBuilder<{toCasing Pascal methodReturnType}>(\"{camelClassName}\")" + NewLine
        do! "{" + NewLine

        yield! writeQueryBuilderAddFieldMethods pascalClassName queryOrMutation context
        yield! writeQueryBuilderAddArgumentMethods pascalClassName queryOrMutation context

        do! NewLine
        do! "}" + NewLine
    }

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

let private writeServicesToPipe (writer: Writer) (context: ParserContext): ValueTask =
    let parsedContext = context :> IParsedContext

    pipeWriter writer {
        // Always write the namespace and usings at the very top of the document
        yield! writeNamespaceAndUsings

        for queryOrMutationType in context.GetQueryOrMutationTypes () do
            yield! writeQueryOrMutationServices queryOrMutationType context
    }

let writeServicesToFileSystem(destination: FileSystemDestination) (context: ParserContext): ValueTask =
    let cancellationToken = context.CancellationToken

    ValueTask(task {
        let pipe = Pipe(PipeOptions())
        let readTask = (readPipe pipe.Reader cancellationToken).ConfigureAwait(false)

        do! writeServicesToPipe pipe.Writer context
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
