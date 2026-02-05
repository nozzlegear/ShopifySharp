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
    public sealed class MarketDeletePayloadQueryBuilder : FieldsQueryBuilderBase<MarketDeletePayload, MarketDeletePayloadQueryBuilder>
    {
        protected override MarketDeletePayloadQueryBuilder Self => this;

        public MarketDeletePayloadQueryBuilder() : this("marketDeletePayload")
        {
        }

        public MarketDeletePayloadQueryBuilder(string name) : base(new Query<MarketDeletePayload>(name))
        {
        }

        public MarketDeletePayloadQueryBuilder(IQuery<MarketDeletePayload> query) : base(query)
        {
        }

        public MarketDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public MarketDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}