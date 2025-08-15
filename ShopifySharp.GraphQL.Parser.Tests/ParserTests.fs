module ShopifySharp.GraphQL.Parser.Tests.ParserTests

open System
open System.Threading
open Faqt
open Faqt.Operators
open Xunit
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.Parser

type ParserTests() =

    let simpleGraphqlSchema = """
        type User {
            id: ID!
            name: String
            email: String!
        }
        
        enum UserStatus {
            ACTIVE
            INACTIVE
        }
        
        input UserInput {
            name: String
            email: String!
        }
    """

    let complexGraphqlSchema = """
        interface Node {
            id: ID!
        }
        
        type User implements Node {
            id: ID!
            name: String
            posts: [Post!]!
        }
        
        type Post implements Node {
            id: ID!
            title: String!
            author: User!
        }
        
        union SearchResult = User | Post
        
        type Query {
            users: [User!]!
            posts: [Post!]!
            search(query: String!): [SearchResult!]!
        }
    """

    [<Theory>]
    [<CombinatorialData>]
    member _.``ParseAsync should parse simple GraphQL schema``(
        [<CombinatorialValues("pascal", "camel")>] casingType: string,
        assumeNullability: bool
    ) =
        // Setup
        let casing =
            match casingType with
            | "pascal" -> Pascal
            | "camel" -> Camel
            | _ -> failwithf $"Unhandled {nameof casingType} value \"{casingType}\""
        let graphqlData = ReadOnlyMemory<char>(simpleGraphqlSchema.ToCharArray())
        let cancellationToken = CancellationToken.None

        // Act
        let task = ParseAsync casing assumeNullability graphqlData cancellationToken
        let result = task.GetAwaiter().GetResult()

        // Assert
        %result.Should().NotBeEmpty()
        let typeNames = result |> Array.map (fun t ->
            match t with
            | VisitedTypes.Class c -> c.Name
            | VisitedTypes.Interface i -> i.Name
            | VisitedTypes.Enum e -> e.Name
            | VisitedTypes.InputObject io -> io.Name
            | VisitedTypes.UnionType u -> u.Name
        )
        %typeNames.Should().Contain("User")
        %typeNames.Should().Contain("UserStatus")
        %typeNames.Should().Contain("UserInput")

    [<Theory>]
    [<CombinatorialData>]
    member _.``ParseAsync should parse complex GraphQL schema with interfaces and unions``(
        [<CombinatorialValues("pascal", "camel")>] casingType: string
    ) =
        // Setup
        let casing =
            match casingType with
            | "pascal" -> Pascal
            | "camel" -> Camel
            | _ -> failwithf $"Unhandled {nameof casingType} value \"{casingType}\""
        let graphqlData = ReadOnlyMemory<char>(complexGraphqlSchema.ToCharArray())
        let cancellationToken = CancellationToken.None

        // Act
        let task = ParseAsync casing false graphqlData cancellationToken
        let result = task.GetAwaiter().GetResult()

        // Assert
        %result.Should().NotBeEmpty()
        let typeNames = result |> Array.map (fun t ->
            match t with
            | VisitedTypes.Class c -> c.Name
            | VisitedTypes.Interface i -> i.Name
            | VisitedTypes.Enum e -> e.Name
            | VisitedTypes.InputObject io -> io.Name
            | VisitedTypes.UnionType u -> u.Name
        )
        
        %typeNames.Should().Contain("INode")
        %typeNames.Should().Contain("User")
        %typeNames.Should().Contain("Post")
        %typeNames.Should().Contain("SearchResult")
        %typeNames.Should().Contain("Query")

    [<Fact>]
    member _.``ParseAsync should handle empty GraphQL schema``() =
        // Setup
        let emptySchema = ""
        let graphqlData = ReadOnlyMemory<char>(emptySchema.ToCharArray())
        let cancellationToken = CancellationToken.None

        // Act
        let task = ParseAsync Pascal false graphqlData cancellationToken
        let result = task.GetAwaiter().GetResult()

        // Assert
        %result.Should().BeEmpty()

    [<Fact>]
    member _.``ParseAsync should handle schema with only comments``() =
        // Setup
        let commentOnlySchema = """
            # This is a comment
            # Another comment
        """
        let graphqlData = ReadOnlyMemory<char>(commentOnlySchema.ToCharArray())
        let cancellationToken = CancellationToken.None

        // Act
        let task = ParseAsync Pascal false graphqlData cancellationToken
        let result = task.GetAwaiter().GetResult()

        // Assert
        %result.Should().BeEmpty()

    [<Fact>]
    member _.``ParseAsync should throw when GraphQL schema is invalid``() =
        // Setup
        let invalidSchema = """
            type User {
                id: ID!
                name: String
                # Missing closing brace
        """
        let graphqlData = ReadOnlyMemory<char>(invalidSchema.ToCharArray())
        let cancellationToken = CancellationToken.None

        // Act & Assert
        let act = fun () -> 
            let task = ParseAsync Pascal false graphqlData cancellationToken
            task.GetAwaiter().GetResult() |> ignore

        %act.Should().Throw<Exception, _>()

    [<Fact>]
    member _.``ParseAsync should handle cancelled cancellation token``() = task {
        // Setup
        let graphqlData = ReadOnlyMemory<char>(simpleGraphqlSchema.ToCharArray())
        let cancellationTokenSource = new CancellationTokenSource()
        cancellationTokenSource.Cancel()

        // Act & Assert
        let act () =
            ParseAsync Pascal false graphqlData cancellationTokenSource.Token
            |> _.AsTask()
            |> Async.AwaitTask
            |> Async.RunSynchronously

        %act.Should().Throw<OperationCanceledException, _>()
    }

    [<Fact>]
    member _.``ParseAsync should parse schema with deprecated fields``() =
        // Setup
        let schemaWithDeprecation = """
            type User {
                id: ID!
                name: String
                oldField: String @deprecated(reason: "Use newField instead")
                newField: String
            }
        """
        let graphqlData = ReadOnlyMemory<char>(schemaWithDeprecation.ToCharArray())
        let cancellationToken = CancellationToken.None

        // Act
        let task = ParseAsync Pascal false graphqlData cancellationToken
        let result = task.GetAwaiter().GetResult()

        // Assert
        %result.Should().NotBeEmpty()
        let userType = result |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "User" -> Some c
            | _ -> None
        )
        
        %userType.Should().BeSome()
        let deprecatedField = userType.Value.Fields |> Array.tryFind (fun f -> f.Name = "oldField")
        %deprecatedField.Should().BeSome()
        %deprecatedField.Value.Deprecation.Should().BeSome()

    [<Theory>]
    [<CombinatorialData>]
    member _.``ParseAsync should handle different scalar types``(
        [<CombinatorialValues("String", "Int", "Float", "Boolean", "ID")>] scalarType: string
    ) =
        // Setup
        let schemaWithScalar = $"""
            type TestType {{
                field: {scalarType}
            }}
        """
        let graphqlData = ReadOnlyMemory<char>(schemaWithScalar.ToCharArray())
        let cancellationToken = CancellationToken.None

        // Act
        let task = ParseAsync Pascal false graphqlData cancellationToken
        let result = task.GetAwaiter().GetResult()

        // Assert
        %result.Should().NotBeEmpty()
        let testType = result |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "TestType" -> Some c
            | _ -> None
        )
        
        %testType.Should().BeSome()
        %testType.Value.Fields.Should().HaveLength(1)
        %testType.Value.Fields[0].Name.Should().Be("field")
