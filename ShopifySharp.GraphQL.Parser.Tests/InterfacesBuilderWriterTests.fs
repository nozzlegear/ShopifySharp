namespace ShopifySharp.GraphQL.Parser.Tests

open System.Collections.Generic
open GraphQLParser.AST
open ShopifySharp.GraphQL.Parser
open Xunit
open Faqt
open Faqt.Operators

type InterfacesBuilderWriterTests() =
    /// Creates an object representing a `[INode!]!`
    let createInterfaceCollectionFieldType interfaceName =
        FieldValueType.GraphObjectType(NamedType.Interface interfaceName)
        |> ValueType
        |> NonNullableType
        |> CollectionType
        |> NonNullableType

    /// Creates an object representing a `Shop!`
    let createClassFieldType className =
        FieldValueType.GraphObjectType(NamedType.Class className)
        |> ValueType
        |> NonNullableType

    /// Creates a mock IParsedContext with the given interface implementation mappings.
    let createMockContext (interfaceImplementations: Map<string, string[]>) =
        { new IParsedContext with
            member _.CasingType = Pascal
            member _.AssumeNullability = false
            member _.Document = GraphQLDocument(List<ASTNode>())
            member _.TypeIsKnownUnionCase _ = false
            member _.IsNamedType _ = true
            member _.TryFindGraphObjectType name =
                // Return a mock interface type definition if the name matches a known interface
                if interfaceImplementations.ContainsKey name then
                    Some (Interface {
                        Name = name
                        DotnetName = "I" + name
                        XmlSummary = Array.empty
                        Deprecation = None
                        Fields = Array.empty
                        InheritedTypeNames = Array.empty
                    })
                else
                    None
            member _.TryFindDocumentNode _ = None
            member _.GetVisitedTypes() = Array.empty
            member _.GetInterfaceImplementationTypeNames interfaceName =
                match interfaceImplementations.TryGetValue interfaceName with
                | true, interfaceNames -> interfaceNames
                | false, _ -> Array.empty
        }

    /// Creates a synthetic VisitedTypes.Operation with the given return type.
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
    member _.``When creating interface field builders with an interface operation, a single builder is returned with implementations as cases``() =
        // Setup
        let interfaceImplementations = Map [ "Node", [| "Product"; "Variant"; "ShopifyFile" |] ]
        let context = createMockContext interfaceImplementations
        let fieldType = createInterfaceCollectionFieldType "Node"
        let visitedType = createOperationWithReturnType (ReturnType.FieldType fieldType)

        // Act
        let writer = InterfacesBuilderWriter(visitedType, context)
        let builders = writer.InterfaceFieldBuilders

        // Assert
        // implementation creates ONE builder with all implementations as interface case names
        %builders.Should().ContainExactlyOneItem()
            .And.AllSatisfy(fun x -> x.PascalFieldName.Should().Be "Node")

    [<Fact>]
    member _.``When creating interface field builders with an interface operation having no implementations, an empty list is returned``() =
        // Setup
        let interfaceImplementations = Map [ "Node", [||] ]
        let context = createMockContext interfaceImplementations
        let fieldType = createInterfaceCollectionFieldType "Node"
        let visitedType = createOperationWithReturnType (ReturnType.FieldType fieldType)

        // Act
        let writer = InterfacesBuilderWriter(visitedType, context)
        let builders = writer.InterfaceFieldBuilders

        // Assert
        %builders.Should().BeEmpty()

    [<Fact>]
    member _.``When creating interface field builders with an interface operation having no known implementations, an empty list is returned``() =
        // Setup - interface not in the mappings at all
        let context = createMockContext Map.empty
        let fieldType = createInterfaceCollectionFieldType "UnknownInterface"
        let visitedType = createOperationWithReturnType (ReturnType.FieldType fieldType)

        // Act
        let writer = InterfacesBuilderWriter(visitedType, context)
        let builders = writer.InterfaceFieldBuilders

        // Assert
        %builders.Should().BeEmpty()

    [<Fact>]
    member _.``When checking if concrete cases can be added for an interface operation, true is returned``() =
        // Setup
        let fieldType = createInterfaceCollectionFieldType "Node"
        let visitedType = createOperationWithReturnType (ReturnType.FieldType fieldType)

        // Act
        let canAdd = InterfacesBuilderWriter.CanAddInterfacesConcreteCases visitedType

        // Assert
        %canAdd.Should().BeTrue()

    [<Fact>]
    member _.``When checking if concrete cases can be added for a class operation, false is returned``() =
        // Setup
        let fieldType = createClassFieldType "Shop"
        let visitedType = createOperationWithReturnType (ReturnType.FieldType fieldType)

        // Act
        let canAdd = InterfacesBuilderWriter.CanAddInterfacesConcreteCases visitedType

        // Assert
        %canAdd.Should().BeFalse()
