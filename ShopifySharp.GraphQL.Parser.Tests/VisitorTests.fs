module ShopifySharp.GraphQL.Parser.Tests.VisitorTests

open System.Threading
open Faqt
open Faqt.Operators
open Xunit
open GraphQLParser.Visitors
open ShopifySharp.GraphQL.Parser

type VisitorTests() =
    let parseDocument (document: string) = GraphQLParser.Parser.Parse(document)

    [<Fact>]
    member _.``Visitor should inherit from ASTVisitor``() =
        // Setup & Act
        let sut = Visitor()

        // Assert
        %sut.Should().BeAssignableTo<ASTVisitor<ParserContext>>()

    [<Theory>]
    [<CombinatorialData>]
    member _.``Visitor should handle GraphQL object type definition``(
        [<CombinatorialValues("User", "Product", "Order")>] typeName: string
    ) =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        // Create a simple GraphQL schema with the type
        let schema = $"""
            type {typeName} {{
                id: ID!
                name: String
            }}
        """
        let document = parseDocument(schema)

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        %visitedTypes.Should().NotBeEmpty()
        
        let objectType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = typeName -> Some c
            | _ -> None
        )
        
        %objectType.Should().BeSome()
        %objectType.Value.Fields.Should().HaveLength(2)

    [<Fact>]
    member _.``Visitor should handle GraphQL interface definition``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            interface Node {
                id: ID!
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        %visitedTypes.Should().NotBeEmpty()
        
        let interfaceType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Interface i when i.Name = "INode" -> Some i
            | _ -> None
        )
        
        %interfaceType.Should().BeSome()
        %interfaceType.Value.Fields.Should().HaveLength(1)
        %interfaceType.Value.Fields[0].Name.Should().Be("id")

    [<Fact>]
    member _.``Visitor should handle GraphQL enum definition``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            enum UserStatus {
                ACTIVE
                INACTIVE
                PENDING
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        %visitedTypes.Should().NotBeEmpty()
        
        let enumType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Enum e when e.Name = "UserStatus" -> Some e
            | _ -> None
        )
        
        %enumType.Should().BeSome()
        %enumType.Value.Cases.Should().HaveLength(3)
        let caseNames = enumType.Value.Cases |> Array.map (fun c -> c.Name)
        %caseNames.Should().Contain("ACTIVE")
        %caseNames.Should().Contain("INACTIVE")
        %caseNames.Should().Contain("PENDING")

    [<Fact>]
    member _.``Visitor should handle GraphQL input object definition``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            input UserInput {
                name: String!
                email: String!
                age: Int
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        %visitedTypes.Should().NotBeEmpty()
        
        let inputType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.InputObject io when io.Name = "UserInput" -> Some io
            | _ -> None
        )
        
        %inputType.Should().BeSome()
        %inputType.Value.Fields.Should().HaveLength(3)
        let fieldNames = inputType.Value.Fields |> Array.map (fun f -> f.Name)
        %fieldNames.Should().Contain("name")
        %fieldNames.Should().Contain("email")
        %fieldNames.Should().Contain("age")

    [<Fact>]
    member _.``Visitor should handle GraphQL union type definition``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            type User {
                id: ID!
            }
            
            type Product {
                id: ID!
            }
            
            union SearchResult = User | Product
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        %visitedTypes.Should().NotBeEmpty()
        
        let unionType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.UnionType u when u.Name = "SearchResult" -> Some u
            | _ -> None
        )
        
        %unionType.Should().BeSome()
        %unionType.Value.Types.Should().HaveLength(2)
        %unionType.Value.Types.Should().Contain("User")
        %unionType.Value.Types.Should().Contain("Product")

    [<Fact>]
    member _.``Visitor should handle type with deprecated field``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            type User {
                id: ID!
                name: String
                oldField: String @deprecated(reason: "Use newField instead")
                newField: String
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        let userType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "User" -> Some c
            | _ -> None
        )
        
        %userType.Should().BeSome()
        let deprecatedField = userType.Value.Fields |> Array.tryFind (fun f -> f.Name = "oldField")
        %deprecatedField.Should().BeSome()
        %deprecatedField.Value.Deprecation.Should().BeSome()
        %deprecatedField.Value.Deprecation.Value.Should().Be("Use newField instead")

    [<Fact>]
    member _.``Visitor should handle type with field descriptions``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            type User {
                "The unique identifier for the user"
                id: ID!
                "The user's display name"
                name: String
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        let userType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "User" -> Some c
            | _ -> None
        )
        
        %userType.Should().BeSome()
        %userType.Value.Fields.Should().HaveLength(2)
        
        let idField = userType.Value.Fields |> Array.find (fun f -> f.Name = "id")
        %idField.XmlSummary.Should().NotBeEmpty()
        %idField.XmlSummary.Should().Contain("/// <summary>")
        %idField.XmlSummary.Should().Contain("/// The unique identifier for the user")

    [<Theory>]
    [<CombinatorialData>]
    member _.``Visitor should handle different scalar types``(
        [<CombinatorialValues("String", "Int", "Float", "Boolean", "ID")>] scalarType: string
    ) =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = $"""
            type TestType {{
                field: {scalarType}
            }}
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        let testType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "TestType" -> Some c
            | _ -> None
        )
        
        %testType.Should().BeSome()
        %testType.Value.Fields.Should().HaveLength(1)
        %testType.Value.Fields[0].Name.Should().Be("field")

    [<Fact>]
    member _.``Visitor should handle type implementing interface``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            interface Node {
                id: ID!
            }
            
            type User implements Node {
                id: ID!
                name: String
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        let userType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "User" -> Some c
            | _ -> None
        )
        
        %userType.Should().BeSome()
        %userType.Value.InheritedTypeNames.Should().Contain("INode")

    [<Fact>]
    member _.``Visitor should handle connection type with both nodes and edges fields``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            type UserConnection {
                nodes: [User]
                edges: [UserEdge]
                pageInfo: PageInfo
            }
            
            type User {
                id: ID!
            }
            
            type UserEdge {
                node: User
            }
            
            type PageInfo {
                hasNextPage: Boolean
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        let connectionType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "UserConnection" -> Some c
            | _ -> None
        )
        
        %connectionType.Should().BeSome()
        match connectionType.Value.KnownInheritedType with
        | Some (Connection (ConnectionWithNodesAndEdges (nodesType, edgesType))) -> 
            %true.Should().BeTrue() // Test passes
        | _ -> 
            %false.Should().BeTrue() // Should have ConnectionWithNodesAndEdges

    [<Fact>]
    member _.``Visitor should handle connection type with only nodes field``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            type UserConnection {
                nodes: [User]
                pageInfo: PageInfo
            }
            
            type User {
                id: ID!
            }
            
            type PageInfo {
                hasNextPage: Boolean
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        let connectionType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "UserConnection" -> Some c
            | _ -> None
        )
        
        %connectionType.Should().BeSome()
        match connectionType.Value.KnownInheritedType with
        | Some (Connection (ConnectionWithNodes nodesType)) -> 
            %true.Should().BeTrue() // Test passes
        | _ -> 
            %false.Should().BeTrue() // Should have ConnectionWithNodes

    [<Fact>]
    member _.``Visitor should handle connection type with only edges field``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            type UserConnection {
                edges: [UserEdge]
                pageInfo: PageInfo
            }
            
            type UserEdge {
                node: User
            }
            
            type User {
                id: ID!
            }
            
            type PageInfo {
                hasNextPage: Boolean
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        let connectionType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "UserConnection" -> Some c
            | _ -> None
        )
        
        %connectionType.Should().BeSome()
        match connectionType.Value.KnownInheritedType with
        | Some (Connection (ConnectionWithEdges edgesType)) -> 
            %true.Should().BeTrue() // Test passes
        | _ -> 
            %false.Should().BeTrue() // Should have ConnectionWithEdges

    [<Fact>]
    member _.``Visitor should handle connection type with neither nodes nor edges fields``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            type UserConnection {
                pageInfo: PageInfo
                totalCount: Int
            }
            
            type PageInfo {
                hasNextPage: Boolean
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        let connectionType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "UserConnection" -> Some c
            | _ -> None
        )
        
        %connectionType.Should().BeSome()
        match connectionType.Value.KnownInheritedType with
        | Some (Connection ConnectionType.Connection) -> 
            %true.Should().BeTrue() // Test passes
        | _ -> 
            %false.Should().BeTrue() // Should have basic Connection

    [<Fact>]
    member _.``Visitor should handle connection type with case insensitive field names``() =
        // Setup
        let cancellationToken = CancellationToken.None
        let context = ParserContext(Pascal, false, cancellationToken)
        let sut = Visitor()

        let schema = """
            type UserConnection {
                NODES: [User]
                Edges: [UserEdge]
                pageInfo: PageInfo
            }
            
            type User {
                id: ID!
            }
            
            type UserEdge {
                node: User
            }
            
            type PageInfo {
                hasNextPage: Boolean
            }
        """
        let document = parseDocument schema

        // Act
        let task = sut.VisitAsync(document, context)
        task.GetAwaiter().GetResult()

        // Assert
        let visitedTypes = context.GetVisitedTypes()
        let connectionType = visitedTypes |> Array.tryPick (fun t ->
            match t with
            | VisitedTypes.Class c when c.Name = "UserConnection" -> Some c
            | _ -> None
        )
        
        %connectionType.Should().BeSome()
        match connectionType.Value.KnownInheritedType with
        | Some (Connection (ConnectionWithNodesAndEdges (nodesType, edgesType))) -> 
            %true.Should().BeTrue() // Test passes - case insensitive matching works
        | _ -> 
            %false.Should().BeTrue() // Should have ConnectionWithNodesAndEdges
