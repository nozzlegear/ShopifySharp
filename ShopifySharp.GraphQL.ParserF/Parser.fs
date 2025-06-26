module ShopifySharp.GraphQL.ParserF.Parser

open System
open System.Threading
open System.Threading.Tasks
open FSharp.Control
open GraphQLParser
open GraphQLParser.Visitors

let Parse (casing: Casing) (graphqlData: ReadOnlyMemory<char>) (cancellationToken: CancellationToken): ValueTask =
    let context = ParserContext(casing, cancellationToken)
    let visitor: ASTVisitor<ParserContext> = Visitor()

    // Read the GraphQL document
    let ast = Parser.Parse(graphqlData)

    ValueTask(task {
        do! visitor.VisitAsync(ast, context)
        do! Writer.writeVisitedTypesToFileSystem  "generated/fsharp" (context.GetVisitedTypes()) CancellationToken.None
    })
