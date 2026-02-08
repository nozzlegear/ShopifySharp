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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class MetafieldDefinitionPinPayloadQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionPinPayload, MetafieldDefinitionPinPayloadQueryBuilder>
    {
        protected override MetafieldDefinitionPinPayloadQueryBuilder Self => this;

        public MetafieldDefinitionPinPayloadQueryBuilder() : this("metafieldDefinitionPinPayload")
        {
        }

        public MetafieldDefinitionPinPayloadQueryBuilder(string name) : base(new Query<MetafieldDefinitionPinPayload>(name))
        {
        }

        public MetafieldDefinitionPinPayloadQueryBuilder(IQuery<MetafieldDefinitionPinPayload> query) : base(query)
        {
        }

        public MetafieldDefinitionPinPayloadQueryBuilder PinnedDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("pinnedDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionPinPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionPinUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionPinUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionPinUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionPinUserError>(query);
            return this;
        }
    }
}