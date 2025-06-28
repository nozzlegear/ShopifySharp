module ShopifySharp.GraphQL.ParserF.Writer

open System
open System.IO
open System.IO.Pipelines
open System.Linq
open System.Text
open System.Threading
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

let private writeFileToPath filePath (fileText: string) cancellationToken: ValueTask =
    ValueTask(task {
        if File.Exists(filePath) then
            File.Delete(filePath)

        let directory = Path.GetDirectoryName filePath

        if directory <> "" && not (Directory.Exists directory) then
            %Directory.CreateDirectory(directory)

        do! File.WriteAllTextAsync(filePath, fileText, cancellationToken)
    })

let private parseCsharpStringToGeneratedFiles (csharpCode: string) cancellationToken: ValueTask<GeneratedCsharpFile[]> =
    ValueTask<GeneratedCsharpFile[]>(task {
        let! csharpTree = CSharpSyntaxTree.ParseText(csharpCode).GetRootAsync(cancellationToken)
        let syntaxRoot = csharpTree :?> CompilationUnitSyntax;
        let usings = syntaxRoot.Usings;
        let externals = syntaxRoot.Externs

        return
            syntaxRoot.Members.OfType<BaseNamespaceDeclarationSyntax>()
            |> Seq.collect (fun ns -> ns.Members.OfType<BaseTypeDeclarationSyntax>()
                                      |> Seq.map (fun types -> (ns, types)))
            |> Seq.map (fun (ns, type') ->
                let unit = SyntaxFactory.CompilationUnit()
                            .WithExterns(externals)
                            .WithUsings(usings)
                            .AddMembers(ns.WithMembers(SyntaxFactory.SingletonList<MemberDeclarationSyntax>(type')))
                            .NormalizeWhitespace(eol = Environment.NewLine)

                { FileName = type'.Identifier.Text + ".cs"
                  FileText = unit.ToFullString() }
            )
            |> Array.ofSeq
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

let private toCasing casing (str: string): string =
    let first = str[0]
    let rest  = str[1..]
    match casing with
    | Pascal -> Char.ToUpper(first).ToString() + rest
    | Camel -> Char.ToLower(first).ToString() + rest

let private mapValueTypeToString = function
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
    | FieldValueType.GraphObjectType graphObjectTypeName -> graphObjectTypeName

let rec private mapFieldTypeToString (valueType: FieldType) (collectionHandling: FieldTypeCollectionHandling) =
    match valueType with
    | ValueType valueType -> mapValueTypeToString valueType
    | NonNullableType nonNullableType -> mapFieldTypeToString nonNullableType collectionHandling
    | NullableType nullableType -> $"{mapFieldTypeToString nullableType collectionHandling}?"
    | CollectionType collectionType ->
        let mappedType = mapFieldTypeToString collectionType collectionHandling
        match collectionHandling with
        | KeepCollection -> $"ICollection<{mappedType}>"
        | UnwrapCollection -> mappedType

let private writeNamespaceAndUsings (writer: Writer) : ValueTask =
    pipeWriter writer {
        do! "namespace ShopifySharp.GraphQL;"
        do! NewLine
        do! "using System;"
        do! NewLine
        do! "using System.Text.Json;"
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
        do! "\t" + $"[JsonProperty(\"{propertyName}\")]"
        do! NewLine
    }

let private writeJsonDerivedTypeAttributes (typeNames: string[]) writer: ValueTask =
    pipeWriter writer {
        do! "[(JsonPolymorphic(TypeDiscriminatorPropertyName = \"__typename\")]"
        do! NewLine

        for typeName in typeNames do
            do! $"""[(JsonDerivedType(typeof({typeName}), typeDiscriminator: "{typeName}")]"""
            do! NewLine
    }

let private writeClassKnownInheritedType className (inheritedType: ClassInheritedType) writer: ValueTask =
    pipeWriter writer {
        match inheritedType with
        | GenericEdge ->
            $"Edge<{className}>"
        | GenericGraphQLObject ->
            $"GraphQLObject<{className}>"
        | Connection ConnectionType.Connection ->
            "IConnection"
        | Connection (ConnectionWithEdges edgeType) ->
            $"IConnection<{mapFieldTypeToString edgeType UnwrapCollection}>"
        | Connection (ConnectionWithNodes nodeType) ->
            $"IConnectionWithNodes<{mapFieldTypeToString nodeType UnwrapCollection}>"
        | Connection (ConnectionWithNodesAndEdges (nodeType, edgeType)) ->
            $"IConnectionWithNodesAndEdges<{mapFieldTypeToString nodeType UnwrapCollection}, {mapFieldTypeToString edgeType UnwrapCollection}>"
    }

let private writeFields (fields: Field[]) writer : ValueTask =
    pipeWriter writer {
        for field in fields do
            let fieldType = mapFieldTypeToString field.ValueType KeepCollection

            yield! writeSummary Indented field.XmlSummary
            yield! writeJsonPropertyAttribute field.Name
            yield! writeDeprecationAttribute Indented field.Deprecation

            do! (toTab Indented) + $$"""public {{fieldType}} {{toCasing Casing.Camel field.Name}} { get; set; }"""
            do! NewLine
    }

let private writeClass (class': Class) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented class'.XmlSummary
        yield! writeDeprecationAttribute Outdented class'.Deprecation

        do! $"public record {class'.Name}: "
        yield! writeClassKnownInheritedType class'.Name class'.KnownInheritedType

        if class'.InheritedTypeNames.Length > 0 then
            do! ", "
            do! String.Join(", ", class'.InheritedTypeNames)

        do! NewLine
        do! "{"
        do! NewLine

        yield! writeFields class'.Fields

        do! "}"
        do! NewLine
    }

let private writeInterface (interface': Interface) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented interface'.XmlSummary
        yield! writeDeprecationAttribute Outdented interface'.Deprecation

        do! $"public interface {interface'.Name}: IGraphQLObject"

        if interface'.InheritedTypeNames.Length > 0 then
            do! ", "
            do! String.Join(", ", interface'.InheritedTypeNames)

        do! NewLine
        do! "{"
        do! NewLine

        yield! writeFields interface'.Fields

        do! "}"
        do! NewLine
    }

let private writeEnum (enum: VisitedEnum) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented enum.XmlSummary
        yield! writeDeprecationAttribute Outdented enum.Deprecation

        do! $"public enum {enum.Name}"
        do! NewLine
        do! "{"
        do! NewLine

        for case in enum.Cases do
            yield! writeDeprecationAttribute Outdented case.Deprecation

            do! $"\t{case.Name}"
            if Option.isSome case.Value then
                do! " = " + (Option.get case.Value)
            do! ","
            do! NewLine

        do! "}"
        do! NewLine
    }

let private writeInputObject (inputObject: InputObject) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented inputObject.XmlSummary
        yield! writeDeprecationAttribute Outdented inputObject.Deprecation

        do! $"public record {inputObject.Name}: GraphQLInputObject"

        do! NewLine
        do! "{"
        do! NewLine

        yield! writeFields inputObject.Fields

        do! "}"
        do! NewLine
    }

let private writeUnionType (unionType: UnionType) (writer: Writer): ValueTask =
    pipeWriter writer {
        yield! writeSummary Outdented unionType.XmlSummary
        yield! writeDeprecationAttribute Outdented unionType.Deprecation
        yield! writeJsonDerivedTypeAttributes unionType.Types

        do! $"public interface I{unionType.Name}Union: IGraphQLUnionType<"
        do! String.Join(", ", unionType.Types)
        do! ">"

        do! NewLine
        do! "{"
        do! NewLine

        // These default interface methods are only usable in .NET 6.0 and above - anything lower will cause
        // the compiler to throw an error.
        do! "#IF NET6_0_OR_GREATER"
        do! NewLine

        for typeName in unionType.Types do
            do! (toTab Indented) + $"public {typeName}? As{typeName}() => this as {typeName};"
            do! NewLine

        do! "#ENDIF"
        do! NewLine
        do! "}"
        do! NewLine
    }

let writeVisitedTypesToPipe (writer: Writer) (visitedTypes: VisitedTypes[]) (_: CancellationToken): ValueTask =
    pipeWriter writer {
        // Always write the namespace and usings at the very top of the document
        yield! writeNamespaceAndUsings

        for visitedType in visitedTypes do
            match visitedType with
            | Class class' ->
                yield! writeClass class'
            | Interface interface' ->
                yield! writeInterface interface'
            | Enum enum' ->
                yield! writeEnum enum'
            | InputObject inputObject ->
                yield! writeInputObject inputObject
            | UnionType unionType ->
                yield! writeUnionType unionType
    }

let writeVisitedTypesToFileSystem (outDir: string) (visitedTypes: VisitedTypes[]) cancellationToken: ValueTask =
    ValueTask(task {
        let pipe = Pipe(PipeOptions(pauseWriterThreshold = 0, resumeWriterThreshold = 0))
        let readTask = (readPipe pipe.Reader cancellationToken).ConfigureAwait(false)

        do! writeVisitedTypesToPipe pipe.Writer visitedTypes cancellationToken
        do! pipe.Writer.CompleteAsync().ConfigureAwait(false);

        let! csharpCode = readTask

        // Write all generated code to a temporary file
        do! writeFileToPath "temp.cs" (csharpCode.ToString()) cancellationToken

        // Parse the generated code into individual files
        let! generatedFiles = parseCsharpStringToGeneratedFiles (csharpCode.ToString()) cancellationToken

        for file in generatedFiles do
            let filePath = Path.Join(outDir, "/", file.FileName)
            do! writeFileToPath filePath file.FileText cancellationToken
    })
