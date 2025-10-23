namespace ShopifySharp.GraphQL.Parser

open System.Diagnostics.CodeAnalysis
open System.Threading.Tasks
open GraphQLParser.AST
open GraphQLParser.Visitors

type Visitor() =
    inherit ASTVisitor<ParserContext>()

    [<ExcludeFromCodeCoverage>]
    let (~%) job = ignore job

    override this.VisitFieldDefinitionAsync(fieldDefinition, context) =
        // This method is called for each query/mutation operation in QueryRoot and Mutation
        let queryOrMutation = AstNodeMapper.mapRootFieldDefinition fieldDefinition context

        context.SetQueryOrMutation queryOrMutation

        ValueTask.CompletedTask

    override this.VisitFieldAsync (field: GraphQLField, context: ParserContext): ValueTask =
        // This override has a SelectionSet property, but isn't called when parsing the schema file.
        // Could be very useful for parsing custom graphql queries.
        base.VisitFieldAsync(field, context)

    override this.VisitObjectTypeDefinitionAsync(objectTypeDefinition, context) =
        context.CancellationToken.ThrowIfCancellationRequested()

        let objectTypeName = objectTypeDefinition.Name.StringValue

        if objectTypeName = "QueryRoot" || objectTypeName = "Mutation" then
            base.VisitObjectTypeDefinitionAsync(objectTypeDefinition, context)
        else
            let class' = AstNodeMapper.mapObjectTypeDefinition objectTypeDefinition

            VisitedTypes.Class class'
            |> context.SetVisitedType

            class'.InheritedTypeNames
            |> context.AddInterfaceRelationship class'.Name

            NamedType.Class class'.Name
            |> context.AddNamedType

            ValueTask.CompletedTask

    override this.VisitInterfaceTypeDefinitionAsync(interfaceTypeDefinition, context) =
        context.CancellationToken.ThrowIfCancellationRequested()

        let interface' = AstNodeMapper.mapInterfaceTypeDefinition interfaceTypeDefinition

        VisitedTypes.Interface interface'
        |> context.SetVisitedType

        NamedType.Interface interface'.Name
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

        let inputObject = AstNodeMapper.mapInputObjectTypeDefinition inputObjectTypeDefinition

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

        NamedType.UnionType unionType.Name
        |> context.AddNamedType

        unionType.Cases
        |> context.AddUnionCases

        ValueTask.CompletedTask
