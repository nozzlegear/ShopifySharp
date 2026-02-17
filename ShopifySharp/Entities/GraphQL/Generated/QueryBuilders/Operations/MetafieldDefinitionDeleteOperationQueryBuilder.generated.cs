#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class MetafieldDefinitionDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionDeletePayload, MetafieldDefinitionDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldDefinitionDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetafieldDefinitionDeleteArgumentsBuilder Arguments { get; }
        protected override MetafieldDefinitionDeleteOperationQueryBuilder Self => this;

        public MetafieldDefinitionDeleteOperationQueryBuilder() : this("metafieldDefinitionDelete")
        {
        }

        public MetafieldDefinitionDeleteOperationQueryBuilder(string name) : base(new Query<MetafieldDefinitionDeletePayload>(name))
        {
            Arguments = new MetafieldDefinitionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionDeleteOperationQueryBuilder(IQuery<MetafieldDefinitionDeletePayload> query) : base(query)
        {
            Arguments = new MetafieldDefinitionDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionDeleteOperationQueryBuilder DeletedDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionIdentifierQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionIdentifier>("deletedDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionIdentifierQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionIdentifier>(query);
            return this;
        }

        public MetafieldDefinitionDeleteOperationQueryBuilder DeletedDefinitionId()
        {
            base.InnerQuery.AddField("deletedDefinitionId");
            return this;
        }

        public MetafieldDefinitionDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionDeleteUserError>(query);
            return this;
        }
    }
}