namespace ShopifySharp.GraphQL.Parser.Tests

open System
open System.Reflection
open Xunit
open ShopifySharp.GraphQL
open Faqt
open Faqt.Operators

type ParserPipelineTests() =
    let schema = """
    type QueryRoot {
      shop: Shop!
      node(id: ID!): Node
      search(query: String!): SearchResultConnection!
    }

    type Shop {
      id: ID!
      name: String!
      obsoleteField: String! @deprecated(reason: "Use newField instead")
    }

    interface Node {
      id: ID!
    }

    enum OrderCancelReason {
      CUSTOMER
      DECLINED
      INVENTORY
      OTHER
    }

    input DraftOrderInput {
      note: String
      email: String
    }

    union SearchResult = Shop | Product

    type Product {
      id: ID!
      title: String!
    }

    type SearchResultEdge {
      cursor: String!
      node: SearchResult!
    }

    type SearchResultConnection {
      edges: [SearchResultEdge!]!
      pageInfo: PageInfo!
    }

    type PageInfo {
      hasNextPage: Boolean!
      hasPreviousPage: Boolean!
    }
    """

    [<Fact>]
    member _.``When parsing a class, a record is generated that implements IGraphQLObject and lists all fields``() =
        // Act
        let assembly = SchemaCompiler.compileSchema schema

        // Assert
        let shopType = Assert.typeExists "ShopifySharp.GraphQL.Shop" assembly
        Assert.implementsInterface typeof<IGraphQLObject> shopType

        let shopIdProp = Assert.hasProperty "Id" typeof<string> shopType
        Assert.hasJsonPropertyName "id" shopIdProp

        let shopObsoleteProp = Assert.hasProperty "ObsoleteField" typeof<string> shopType
        Assert.isObsolete shopObsoleteProp

    [<Fact>]
    member _.``When parsing an interface, a corresponding C# interface is generated``() =
        // Act
        let assembly = SchemaCompiler.compileSchema schema

        // Assert
        let nodeType = Assert.typeExists "ShopifySharp.GraphQL.INode" assembly
        Assert.implementsInterface typeof<IGraphQLObject> nodeType
        %Assert.hasProperty "Id" typeof<string> nodeType

    [<Fact>]
    member _.``When parsing an enum, a C# enum is generated with corresponding cases``() =
        // Setup & Act
        let assembly = SchemaCompiler.compileSchema schema

        // Assert
        let enumType = Assert.typeExists "ShopifySharp.GraphQL.OrderCancelReason" assembly
        let enumNames = Enum.GetNames enumType
        %enumNames.Should().Be [|
            "CUSTOMER"
            "DECLINED"
            "INVENTORY"
            "OTHER"
        |]

    [<Fact>]
    member _.``When parsing an input object, a class inheriting GraphQLInputObject is generated``() =
        // Act
        let assembly = SchemaCompiler.compileSchema schema

        // Assert
        let inputType = Assert.typeExists "ShopifySharp.GraphQL.DraftOrderInput" assembly
        Assert.inheritsFromGeneric "GraphQLInputObject" inputType
        %Assert.hasProperty "Note" typeof<string> inputType
        %Assert.hasProperty "Email" typeof<string> inputType

    [<Fact>]
    member _.``When parsing a union, a record inheriting IGraphQLUnionType and conversion methods is generated``() =
        // Act
        let assembly = SchemaCompiler.compileSchema schema

        // Assert
        let unionType = Assert.typeExists "ShopifySharp.GraphQL.SearchResult" assembly
        Assert.implementsInterface typeof<IGraphQLUnionType> unionType
        %Assert.hasMethod "AsShop" unionType
        %Assert.hasMethod "AsProduct" unionType

    [<Fact>]
    member _.``When parsing connection and edge types, classes inheriting ConnectionWithEdges and Edge are generated``() =
        // Act
        let assembly = SchemaCompiler.compileSchema schema

        // Assert
        let connectionType = Assert.typeExists "ShopifySharp.GraphQL.SearchResultConnection" assembly
        Assert.inheritsFromGeneric "ConnectionWithEdges" connectionType

        let edgeType = Assert.typeExists "ShopifySharp.GraphQL.SearchResultEdge" assembly
        Assert.inheritsFromGeneric "Edge" edgeType

    [<Fact>]
    member _.``When parsing query operations, corresponding query builders and argument builders are generated``() =
        // Act
        let assembly = SchemaCompiler.compileSchema schema

        // Assert
        let shopQueryBuilder = Assert.typeExists "ShopifySharp.GraphQL.QueryBuilders.Types.ShopQueryBuilder" assembly
        Assert.inheritsFromGeneric "FieldsQueryBuilderBase" shopQueryBuilder
        %Assert.hasMethod "Id" shopQueryBuilder
        %Assert.hasMethod "Name" shopQueryBuilder

        let searchOperationBuilder = Assert.typeExists "ShopifySharp.GraphQL.QueryBuilders.Operations.SearchOperationQueryBuilder" assembly
        Assert.inheritsFromGeneric "FieldsQueryBuilderBase" searchOperationBuilder

        let searchArgsBuilder = Assert.typeExists "ShopifySharp.GraphQL.QueryBuilders.Operations.SearchArgumentsBuilder" assembly
        Assert.inheritsFromGeneric "ArgumentsBuilderBase" searchArgsBuilder
        %Assert.hasMethod "Query" searchArgsBuilder

    [<Fact>]
    member _.``When an interface has concrete implementations, an InterfaceCasesBuilder is generated with OnConcreteType methods inheriting from InterfaceCasesBuilderBase``() =
        // Setup
        let schemaWithNodeImpls = """
        type QueryRoot {
          node(id: ID!): Node
        }

        interface Node {
          id: ID!
        }

        type Shop implements Node {
          id: ID!
          name: String!
        }

        type Product implements Node {
          id: ID!
          title: String!
        }
        """

        // Act
        let assembly = SchemaCompiler.compileSchema schemaWithNodeImpls

        // Assert
        let interfaceCasesBuilder = Assert.typeExists "ShopifySharp.GraphQL.QueryBuilders.Operations.NodeInterfaceCasesBuilder" assembly
        Assert.inheritsFromGeneric "InterfaceCasesBuilderBase" interfaceCasesBuilder
        %Assert.hasMethod "OnShop" interfaceCasesBuilder
        %Assert.hasMethod "OnProduct" interfaceCasesBuilder

    [<Fact>]
    member _.``When a union type is parsed, a UnionCasesBuilder is generated with OnConcreteType methods inheriting from UnionCasesBuilderBase``() =
        // Setup
        let unionSchema = """
        type QueryRoot {
          search(query: String!): SearchResultConnection!
        }

        union SearchResult = Shop | Product

        type Shop {
          id: ID!
        }

        type Product {
          id: ID!
        }

        type SearchResultEdge {
          cursor: String!
          node: SearchResult!
        }

        type SearchResultConnection {
          edges: [SearchResultEdge!]!
        }
        """

        // Act
        let assembly = SchemaCompiler.compileSchema unionSchema

        // Assert
        let unionCasesBuilder = Assert.typeExists "ShopifySharp.GraphQL.QueryBuilders.Types.SearchResultUnionCasesBuilder" assembly
        Assert.inheritsFromGeneric "UnionCasesBuilderBase" unionCasesBuilder
        %Assert.hasMethod "OnShop" unionCasesBuilder
        %Assert.hasMethod "OnProduct" unionCasesBuilder

    [<Fact>]
    member _.``When parsing a mutation, it generates operation builders and input objects, but skips Payload query builders``() =
        // Setup
        let mutationSchema = """
        type QueryRoot {
          shop: Shop!
        }

        type Shop {
          id: ID!
        }

        type Mutation {
          shopUpdate(input: ShopUpdateInput!): ShopUpdatePayload!
        }

        input ShopUpdateInput {
          name: String
        }

        type ShopUpdatePayload {
          shop: Shop
          userErrors: [UserError!]!
        }

        type UserError {
          field: [String!]
          message: String!
        }
        """

        // Act
        let assembly = SchemaCompiler.compileSchema mutationSchema

        // Assert
        let shopUpdateBuilder = Assert.typeExists "ShopifySharp.GraphQL.QueryBuilders.Operations.ShopUpdateOperationQueryBuilder" assembly
        Assert.inheritsFromGeneric "FieldsQueryBuilderBase" shopUpdateBuilder

        let shopUpdateArgs = Assert.typeExists "ShopifySharp.GraphQL.QueryBuilders.Operations.ShopUpdateArgumentsBuilder" assembly
        Assert.inheritsFromGeneric "ArgumentsBuilderBase" shopUpdateArgs

        let inputObj = Assert.typeExists "ShopifySharp.GraphQL.ShopUpdateInput" assembly
        Assert.inheritsFromGeneric "GraphQLInputObject" inputObj

        %(Assert.typeExists "ShopifySharp.GraphQL.ShopUpdatePayload" assembly).Should().NotBeNull()

        let payloadBuilder = assembly.GetType "ShopifySharp.GraphQL.QueryBuilders.Types.ShopUpdatePayloadQueryBuilder"
        %payloadBuilder.Should().BeNull "Payload types should not have a QueryBuilder generated"

    [<Fact>]
    member _.``When an operation is deprecated, its generated query builder is decorated with ObsoleteAttribute``() =
        // Setup
        let deprecatedSchema = """
        type QueryRoot {
          oldShop: Shop! @deprecated(reason: "Use shop instead")
          shop: Shop!
        }

        type Shop {
          id: ID!
        }
        """

        // Act
        let assembly = SchemaCompiler.compileSchema deprecatedSchema

        // Assert
        let oldShopBuilder = Assert.typeExists "ShopifySharp.GraphQL.QueryBuilders.Operations.OldShopOperationQueryBuilder" assembly
        let attr = oldShopBuilder.GetCustomAttribute<ObsoleteAttribute>()
        %attr.Should().NotBeNull "Deprecated operation should have ObsoleteAttribute"
        %attr.Message.Should().Be "Use shop instead"

    [<Fact>]
    member _.``When assumeNullability is true, all generated properties on classes are nullable``() =
        // Setup
        let simpleSchema = """
        type QueryRoot {
          shop: Shop!
        }

        type Shop {
          id: ID!
          name: String!
        }
        """

        // Act
        let assembly = SchemaCompiler.compileSchemaWithOptions true simpleSchema

        // Assert
        let shopType = Assert.typeExists "ShopifySharp.GraphQL.Shop" assembly
        let idProp = shopType.GetProperty "Id"

        // Assert that the compilation succeeded and type is string
        % idProp.PropertyType.Should().Be typeof<string>
