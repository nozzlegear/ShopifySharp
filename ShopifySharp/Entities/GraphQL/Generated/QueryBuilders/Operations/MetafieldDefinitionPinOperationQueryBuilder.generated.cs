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

        public MetafieldDefinitionPinOperationQueryBuilder PinnedDefinition(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("pinnedDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionPinOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionPinUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionPinUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionPinUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionPinUserError>(query);
            return this;
        }
    }
}