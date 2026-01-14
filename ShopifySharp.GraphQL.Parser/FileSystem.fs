namespace ShopifySharp.GraphQL.Parser

open System
open System.IO
open System.Linq
open System.Text
open System.Threading.Tasks
open Microsoft.CodeAnalysis
open Microsoft.CodeAnalysis.CSharp
open Microsoft.CodeAnalysis.CSharp.Syntax

[<RequireQualifiedAccess>]
module FileSystem =
    let writeFileToPath filePath (fileText: string) cancellationToken: ValueTask =
        ValueTask(task {
            if File.Exists(filePath) then
                File.Delete(filePath)

            let directory = Path.GetDirectoryName filePath

            if directory <> "" && not (Directory.Exists directory) then
                Directory.CreateDirectory directory
                |> ignore

            do! File.WriteAllTextAsync(filePath, fileText, cancellationToken)
        })

    let private extractSubdirectoryFromNamespace (namespaceName: string): string =
        // Map namespace suffix to subdirectory
        // Operations go in QueryBuilders/Operations, all other QueryBuilders in QueryBuilders/Types
        if namespaceName.Contains(".QueryBuilders.Operations") then "Operations"
        elif namespaceName.Contains(".QueryBuilders.Types") then "Types"
        else ""

    let private parseCsharpStringToGeneratedFiles (csharpCode: string) cancellationToken: ValueTask<GeneratedCsharpFile[]> =
        ValueTask<GeneratedCsharpFile[]>(task {
            let! csharpTree = CSharpSyntaxTree.ParseText(csharpCode).GetRootAsync(cancellationToken)
            let syntaxRoot = csharpTree :?> CompilationUnitSyntax
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

                    let namespaceName = ns.Name.ToString()
                    let subdirectory = extractSubdirectoryFromNamespace namespaceName
                    let fileName =
                        if subdirectory <> "" then
                            Path.Join(subdirectory, type'.Identifier.Text + ".generated.cs")
                        else
                            type'.Identifier.Text + ".generated.cs"

                    { FileName = fileName
                      FileText = unit.ToFullString() }
                )
        })

    let private parseCsharpCodeAndWriteToDirectoryPath directoryPath (csharpCodeStringBuilder: StringBuilder) cancellationToken =
        ValueTask(task {
            let! generatedFiles = parseCsharpStringToGeneratedFiles (csharpCodeStringBuilder.ToString()) cancellationToken
            for file in generatedFiles do
                let filePath = Path.Join(directoryPath, "/", file.FileName)
                do! writeFileToPath filePath file.FileText cancellationToken
        })

    let writeCsharpCodeToFileSystem destination csharpCodeStringBuilder cancellationToken: ValueTask =
        ValueTask(task {
            match destination with
            | SingleFile filePath ->
                do! writeFileToPath filePath (csharpCodeStringBuilder.ToString()) cancellationToken
            | Directory directoryPath ->
                do! parseCsharpCodeAndWriteToDirectoryPath directoryPath csharpCodeStringBuilder cancellationToken
            | DirectoryAndTemporaryFile(directoryPath, temporaryFilePath) ->
                do! writeFileToPath temporaryFilePath (csharpCodeStringBuilder.ToString()) cancellationToken
                do! parseCsharpCodeAndWriteToDirectoryPath directoryPath csharpCodeStringBuilder cancellationToken
        })
