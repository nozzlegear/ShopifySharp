module ShopifySharp.GraphQL.Parser.Parser

open System
open System.Threading
open System.Threading.Tasks
open FSharp.Control
open GraphQLParser
open GraphQLParser.Visitors

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
        do! visitor.VisitAsync(ast, context)
        return context
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
        do! Writer.writeVisitedTypesToFileSystem typesDestination context
        do! QueryBuilderWriter.writeServicesToFileSystem servicesDestination context
    })
