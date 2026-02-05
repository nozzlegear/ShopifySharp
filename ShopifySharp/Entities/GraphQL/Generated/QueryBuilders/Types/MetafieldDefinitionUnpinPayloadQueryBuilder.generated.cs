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
    public sealed class MetafieldDefinitionUnpinPayloadQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionUnpinPayload, MetafieldDefinitionUnpinPayloadQueryBuilder>
    {
        protected override MetafieldDefinitionUnpinPayloadQueryBuilder Self => this;

        public MetafieldDefinitionUnpinPayloadQueryBuilder() : this("metafieldDefinitionUnpinPayload")
        {
        }

        public MetafieldDefinitionUnpinPayloadQueryBuilder(string name) : base(new Query<MetafieldDefinitionUnpinPayload>(name))
        {
        }

        public MetafieldDefinitionUnpinPayloadQueryBuilder(IQuery<MetafieldDefinitionUnpinPayload> query) : base(query)
        {
        }

        public MetafieldDefinitionUnpinPayloadQueryBuilder UnpinnedDefinition(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("unpinnedDefinition");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public MetafieldDefinitionUnpinPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionUnpinUserErrorQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionUnpinUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionUnpinUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionUnpinUserError>(query);
            return this;
        }
    }
}