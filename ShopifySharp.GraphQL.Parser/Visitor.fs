namespace ShopifySharp.GraphQL.Parser

open System.Diagnostics.CodeAnalysis
open System.Threading.Tasks
open GraphQLParser.AST
open GraphQLParser.Visitors

type Visitor() =
    inherit ASTVisitor<ParserContext>()

    [<ExcludeFromCodeCoverage>]
    let (~%) job = ignore job

    override this.VisitFieldDefinitionAsync(_, _) =
        // This method is called for each query/mutation operation in QueryRoot and Mutation
        ValueTask.CompletedTask

    override this.VisitFieldAsync (field: GraphQLField, context: ParserContext): ValueTask =
        // This override has a SelectionSet property, but isn't called when parsing the schema file.
        // Could be very useful for parsing custom graphql queries.
        base.VisitFieldAsync(field, context)

    override this.VisitObjectTypeDefinitionAsync(objectTypeDefinition, context) =
        context.CancellationToken.ThrowIfCancellationRequested()

        let objectTypeName = objectTypeDefinition.Name.StringValue

        if objectTypeName = "Mutation" then
            base.VisitObjectTypeDefinitionAsync(objectTypeDefinition, context)
        else
            let class' = AstNodeMapper.mapObjectTypeDefinition context objectTypeDefinition

            VisitedTypes.Class class'
            |> context.SetVisitedType

            class'.InheritedTypeNames
            |> context.AddInterfaceRelationship class'.Name

            NamedType.Class class'.Name
            |> context.AddNamedType

            ValueTask.CompletedTask

    override this.VisitInterfaceTypeDefinitionAsync(interfaceTypeDefinition, context) =
        context.CancellationToken.ThrowIfCancellationRequested()

        let interface' = AstNodeMapper.mapInterfaceTypeDefinition context interfaceTypeDefinition

        VisitedTypes.Interface interface'
        |> context.SetVisitedType

        // Register the interface with its original schema name (without "I" prefix)
        // so that field type lookups can find it
        NamedType.Interface interfaceTypeDefinition.Name.StringValue
        |> context.AddNamedType

        ValueTask.CompletedTask

    override this.VisitEnumTypeDefinitionAsync(enumTypeDefinition, context) =
        context.CancellationToken.ThrowIfCancellationRequested()

        let enum = AstNodeMapper.mapEnumTypeDefinition enumTypeDefinition

        VisitedTypes.Enum enum
        |> context.SetVisitedType

        NamedType.Enum enum.Name
        |> context.AddNamedType

        ValueTask.CompletedTask

    override this.VisitInputObjectTypeDefinitionAsync(inputObjectTypeDefinition, context) =
        context.CancellationToken.ThrowIfCancellationRequested()

        let inputObject = AstNodeMapper.mapInputObjectTypeDefinition context inputObjectTypeDefinition

        VisitedTypes.InputObject inputObject
        |> context.SetVisitedType

        NamedType.InputObject inputObject.Name
        |> context.AddNamedType

        ValueTask.CompletedTask

    override this.VisitUnionTypeDefinitionAsync(unionTypeDefinition, context) =
        context.CancellationToken.ThrowIfCancellationRequested()

        let unionType = AstNodeMapper.mapUnionTypeDefinition context unionTypeDefinition

        VisitedTypes.UnionType unionType
        |> context.SetVisitedType

        NamedType.UnionType (unionType.Name, unionType.Cases |> Array.map _.Name)
        |> context.AddNamedType

        unionType.Cases
        |> context.AddUnionCases

        ValueTask.CompletedTask
