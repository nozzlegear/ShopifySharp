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
    public sealed class MarketRegionsDeletePayloadQueryBuilder : FieldsQueryBuilderBase<MarketRegionsDeletePayload, MarketRegionsDeletePayloadQueryBuilder>
    {
        protected override MarketRegionsDeletePayloadQueryBuilder Self => this;

        public MarketRegionsDeletePayloadQueryBuilder() : this("marketRegionsDeletePayload")
        {
        }

        public MarketRegionsDeletePayloadQueryBuilder(string name) : base(new Query<MarketRegionsDeletePayload>(name))
        {
        }

        public MarketRegionsDeletePayloadQueryBuilder(IQuery<MarketRegionsDeletePayload> query) : base(query)
        {
        }

        public MarketRegionsDeletePayloadQueryBuilder DeletedIds()
        {
            base.InnerQuery.AddField("deletedIds");
            return this;
        }

        public MarketRegionsDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}