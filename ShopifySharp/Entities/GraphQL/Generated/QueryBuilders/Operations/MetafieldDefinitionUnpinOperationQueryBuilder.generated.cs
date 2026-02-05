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
    public sealed class MetafieldDefinitionUnpinOperationQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionUnpinPayload, MetafieldDefinitionUnpinOperationQueryBuilder>, IGraphOperationQueryBuilder<MetafieldDefinitionUnpinPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MetafieldDefinitionUnpinArgumentsBuilder Arguments { get; }
        protected override MetafieldDefinitionUnpinOperationQueryBuilder Self => this;

        public MetafieldDefinitionUnpinOperationQueryBuilder() : this("metafieldDefinitionUnpin")
        {
        }

        public MetafieldDefinitionUnpinOperationQueryBuilder(string name) : base(new Query<MetafieldDefinitionUnpinPayload>(name))
        {
            Arguments = new MetafieldDefinitionUnpinArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionUnpinOperationQueryBuilder(IQuery<MetafieldDefinitionUnpinPayload> query) : base(query)
        {
            Arguments = new MetafieldDefinitionUnpinArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionUnpinOperationQueryBuilder UnpinnedDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("unpinnedDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionUnpinOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionUnpinUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionUnpinUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionUnpinUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionUnpinUserError>(query);
            return this;
        }
    }
}