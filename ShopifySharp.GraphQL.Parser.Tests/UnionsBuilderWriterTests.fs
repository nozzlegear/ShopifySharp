namespace ShopifySharp.GraphQL.Parser.Tests

open System.Collections.Generic
open GraphQLParser.AST
open ShopifySharp.GraphQL.Parser
open Xunit
open Faqt
open Faqt.Operators

type UnionsBuilderWriterTests() =
    /// Creates an object representing a GraphQL `[INode!]!`
    let createInterfaceCollectionFieldType interfaceName =
        FieldValueType.GraphObjectType(NamedType.Interface interfaceName)
        |> ValueType
        |> NonNullableType
        |> CollectionType
        |> NonNullableType

    /// Creates an object representing a GraphQL `Shop!`
    let createClassFieldType className =
        FieldValueType.GraphObjectType(NamedType.Class className)
        |> ValueType
        |> NonNullableType

    /// Creates an object representing a `SearchResult!`
    let createUnionFieldType unionName caseNames =
        FieldValueType.GraphObjectType(NamedType.UnionType(unionName, caseNames))
        |> ValueType
        |> NonNullableType

    /// Creates a mock IParsedContext with the given interface implementation mappings
    let createMockContext (interfaceImplementations: Map<string, string[]>) =
        { new IParsedContext with
            member _.CasingType = Pascal
            member _.AssumeNullability = false
            member _.Document = GraphQLDocument(List<ASTNode>())
            member _.TypeIsKnownUnionCase _ = false
            member _.IsNamedType _ = true
            member _.TryFindGraphObjectType _ = None
            member _.TryFindDocumentNode _ = None
            member _.GetVisitedTypes() = Array.empty
            member _.GetInterfaceImplementationTypeNames interfaceName =
                match interfaceImplementations.TryGetValue interfaceName with
                | true, interfaceNames -> interfaceNames
                | false, _ -> Array.empty
        }

    /// Creates an Operation with the given return type
    let createOperationWithReturnType returnType =
        let operation =
            { Name = "TestOperation"
              Type = OperationType.Query
              XmlSummary = Array.empty
              Deprecation = None
              Arguments = Array.empty
              ReturnType = returnType }
        Operation operation

    [<Fact>]
    member _.``When checking if unions can be added for an interface operation, false is returned``() =
        // Setup
        let fieldType = createInterfaceCollectionFieldType "Node"
        let visitedType = createOperationWithReturnType (ReturnType.FieldType fieldType)

        // Act
        let canAdd = UnionsBuilderWriter.CanAddUnions visitedType

        // Assert
        %canAdd.Should().BeFalse()

    [<Fact>]
    member _.``When checking if unions can be added for a class operation, false is returned``() =
        // Setup
        let fieldType = createClassFieldType "Shop"
        let visitedType = createOperationWithReturnType (ReturnType.FieldType fieldType)

        // Act
        let canAdd = UnionsBuilderWriter.CanAddUnions visitedType

        // Assert
        %canAdd.Should().BeFalse()

    [<Fact>]
    member _.``When checking if unions can be added for a union operation, false is returned``() =
        // Setup
        let fieldType = createUnionFieldType "SearchResult" [| "Product"; "Page" |]
        let visitedType = createOperationWithReturnType (ReturnType.FieldType fieldType)

        // Act
        let canAdd = UnionsBuilderWriter.CanAddUnions visitedType

        // Assert
        %canAdd.Should().BeFalse()

    [<Fact>]
    member _.``When creating union field builders with a union operation, a single builder is returned``() =
        // Setup
        let context = createMockContext Map.empty
        let fieldType = createUnionFieldType "SearchResult" [| "Product"; "Page" |]
        let visitedType = createOperationWithReturnType (ReturnType.FieldType fieldType)

        // Act
        let writer = UnionsBuilderWriter(visitedType, context)
        let builders = writer.UnionFieldBuilders

        // Assert
        %builders.Should().ContainExactlyOneItem()

    [<Fact>]
    member _.``When creating union field builders with a deprecated union operation, the deprecation warning is passed to the builder``() =
        // Setup
        let context = createMockContext Map.empty
        let fieldType = createUnionFieldType "SearchResult" [| "Product"; "Page" |]
        let deprecationWarning = Some "Use something else"
        let visitedType =
            let operation =
                { Name = "TestOperation"
                  Type = OperationType.Query
                  XmlSummary = Array.empty
                  Deprecation = deprecationWarning
                  Arguments = Array.empty
                  ReturnType = ReturnType.FieldType fieldType }
            Operation operation

        // Act
        let writer = UnionsBuilderWriter(visitedType, context)
        let builders = writer.UnionFieldBuilders

        // Assert
        %builders.Should().ContainExactlyOneItem()
            .And.AllSatisfy(fun builder -> builder.DeprecationWarning.Should().Be deprecationWarning)
