module ShopifySharp.GraphQL.Parser.Tests.IntegrationTests

open System
open System.Threading
open Faqt
open Faqt.Operators
open Xunit
open ShopifySharp.GraphQL.Parser
open ShopifySharp.GraphQL.Parser.Parser

type IntegrationTests() =

    [<Fact>]
    member _.``End-to-end parsing should work with real GraphQL schema``() =
        // Setup
        let graphqlSchema = """
            interface Node {
                id: ID!
            }
            
            type User implements Node {
                id: ID!
                name: String
                email: String!
                posts: [Post!]!
            }
            
            type Post implements Node {
                id: ID!
                title: String!
                content: String
                author: User!
            }
            
            enum PostStatus {
                DRAFT
                PUBLISHED
                ARCHIVED
            }
            
            input PostInput {
                title: String!
                content: String
                status: PostStatus
            }
            
            union SearchResult = User | Post
            
            type Query {
                users: [User!]!
                posts: [Post!]!
                search(query: String!): [SearchResult!]!
            }
        """
        
        let graphqlData = ReadOnlyMemory<char>(graphqlSchema.ToCharArray())
        let cancellationToken = CancellationToken.None

        // Act
        let task = ParseAsync Pascal false graphqlData cancellationToken
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
        %typeNames.Should().Contain("PostStatus")
        %typeNames.Should().Contain("PostInput")
        %typeNames.Should().Contain("SearchResult")
        %typeNames.Should().Contain("Query")
