#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class MetafieldDefinitionPinOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionPinPayload, MetafieldDefinitionPinOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldDefinitionPinPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetafieldDefinitionPinArgumentsBuilder Arguments { get; }
        protected override MetafieldDefinitionPinOperationQueryBuilder Self => this;

        public MetafieldDefinitionPinOperationQueryBuilder() : this("metafieldDefinitionPin")
        {
        }

        public MetafieldDefinitionPinOperationQueryBuilder(string name) : base(new Query<MetafieldDefinitionPinPayload>(name))
        {
            Arguments = new MetafieldDefinitionPinArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionPinOperationQueryBuilder(IQuery<MetafieldDefinitionPinPayload> query) : base(query)
        {
            Arguments = new MetafieldDefinitionPinArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionPinOperationQueryBuilder PinnedDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("pinnedDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionPinOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionPinUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionPinUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionPinUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionPinUserError>(query);
            return this;
        }
    }
}