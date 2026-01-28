module ShopifySharp.GraphQL.Parser.Parser

open System
open System.IO.Pipelines
open System.Threading
open System.Threading.Tasks
open FSharp.Control
open GraphQLParser
open GraphQLParser.Visitors
open ShopifySharp.GraphQL.Parser.Utils

let private parseAsync (casing: Casing)
                       (assumeNullability: bool)
                       (graphqlData: ReadOnlyMemory<char>)
                       cancellationToken
                       : ValueTask<ParserContext> =
    let ast = Parser.Parse(graphqlData)
    let context = ParserContext(casing, assumeNullability, ast, cancellationToken)
    let visitor: ASTVisitor<ParserContext> = Visitor()

    // let sdlThing = StructurePrinter()
    // use writer = new StringWriter()
    // let result = sdlThing.PrintAsync(ast, writer, context.CancellationToken).AsTask()
    //              |> Async.AwaitTask
    //              |> Async.RunSynchronously

    ValueTask<ParserContext>(task {
        // TODO: It's simpler to just skip the visitor concept entirely and pass the parsed GraphDocument to the writers.
        //       The QueryBuilderWriter does this already; the VisitedTypeWriter should do it as well.
        do! visitor.VisitAsync(ast, context)
        return context
    })

let private parseAndWriteToFilesystem (parseAndWriteFn: ParserContext -> PipeWriter -> ValueTask)
                                      (destination: FileSystemDestination)
                                      (context: ParserContext)
                                      : ValueTask =
    let cancellationToken = context.CancellationToken

    ValueTask(task {
        let pipe = Pipe(PipeOptions())
        let readTask = (readPipe pipe.Reader cancellationToken).ConfigureAwait(false)

        do! parseAndWriteFn context pipe.Writer
        do! pipe.Writer.CompleteAsync().ConfigureAwait(false);

        let! csharpCode = readTask
        do! (FileSystem.writeCsharpCodeToFileSystem destination csharpCode cancellationToken).ConfigureAwait(false)
    })

let ParseAsync (casing: Casing)
               (assumeNullability: bool)
               (graphqlData: ReadOnlyMemory<char>)
               (cancellationToken: CancellationToken)
               : ValueTask<VisitedTypes[]> =
    ValueTask<VisitedTypes[]>(task {
        let! context = parseAsync casing assumeNullability graphqlData cancellationToken
        return context.GetVisitedTypes()
    })

let ParseAndWriteAsync (typesDestination: FileSystemDestination, servicesDestination: FileSystemDestination)
                       (casing: Casing)
                       (assumeNullability: bool)
                       (graphqlData: ReadOnlyMemory<char>)
                       cancellationToken
                       : ValueTask =
    ValueTask(task {
        let! context = parseAsync casing assumeNullability graphqlData cancellationToken
        do! parseAndWriteToFilesystem VisitedTypeWriter.writeVisitedTypesToPipe typesDestination context
        do! parseAndWriteToFilesystem QueryBuilderWriter.WriteQueryBuildersToPipe servicesDestination context
    })
