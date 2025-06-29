module ShopifySharp.GraphQL.ParserF.Parser

open System
open System.Threading
open System.Threading.Tasks
open FSharp.Control
open GraphQLParser
open GraphQLParser.Visitors

let Parse (casing: Casing) (graphqlData: ReadOnlyMemory<char>) (cancellationToken: CancellationToken): ValueTask<VisitedTypes[]> =
    let context = ParserContext(casing, cancellationToken)
    let visitor: ASTVisitor<ParserContext> = Visitor()

    // Read the GraphQL document
    let ast = Parser.Parse(graphqlData)

    ValueTask<VisitedTypes[]>(task {
        do! visitor.VisitAsync(ast, context)
        return context.GetVisitedTypes()
    })

let ParseAndWriteAsync (destination: FileSystemDestination)
                       (casing: Casing)
                       (graphqlData: ReadOnlyMemory<char>)
                       cancellationToken
                       : ValueTask =
    ValueTask(task {
        let! visitedTypes = Parse casing graphqlData cancellationToken
        do! Writer.writeVisitedTypesToFileSystem destination visitedTypes cancellationToken
    })
