module ShopifySharp.GraphQL.ParserF.Parser

open System
open System.Threading
open System.Threading.Tasks
open FSharp.Control
open GraphQLParser
open GraphQLParser.Visitors

let private parseAsync (casing: Casing)
                       (graphqlData: ReadOnlyMemory<char>)
                       cancellationToken
                       : ValueTask<ParserContext> =
    let context = ParserContext(casing, cancellationToken)
    let visitor: ASTVisitor<ParserContext> = Visitor()

    // Read the GraphQL document
    let ast = Parser.Parse(graphqlData)

    ValueTask<ParserContext>(task {
        do! visitor.VisitAsync(ast, context)
        return context
    })

let ParseAsync (casing: Casing)
               (graphqlData: ReadOnlyMemory<char>)
               (cancellationToken: CancellationToken)
               : ValueTask<VisitedTypes[]> =
    ValueTask<VisitedTypes[]>(task {
        let! context = parseAsync casing graphqlData cancellationToken
        return context.GetVisitedTypes()
    })

let ParseAndWriteAsync (destination: FileSystemDestination)
                       (casing: Casing)
                       (graphqlData: ReadOnlyMemory<char>)
                       cancellationToken
                       : ValueTask =
    ValueTask(task {
        let! context = parseAsync casing graphqlData cancellationToken
        do! Writer.writeVisitedTypesToFileSystem destination context
    })
