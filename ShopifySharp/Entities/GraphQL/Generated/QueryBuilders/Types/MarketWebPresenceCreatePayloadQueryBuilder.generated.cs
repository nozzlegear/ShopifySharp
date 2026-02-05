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
    public sealed class MarketWebPresenceCreatePayloadQueryBuilder : FieldsQueryBuilderBase<MarketWebPresenceCreatePayload, MarketWebPresenceCreatePayloadQueryBuilder>
    {
        protected override MarketWebPresenceCreatePayloadQueryBuilder Self => this;

        public MarketWebPresenceCreatePayloadQueryBuilder() : this("marketWebPresenceCreatePayload")
        {
        }

        public MarketWebPresenceCreatePayloadQueryBuilder(string name) : base(new Query<MarketWebPresenceCreatePayload>(name))
        {
        }

        public MarketWebPresenceCreatePayloadQueryBuilder(IQuery<MarketWebPresenceCreatePayload> query) : base(query)
        {
        }

        public MarketWebPresenceCreatePayloadQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketWebPresenceCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketUserError>(query);
            return this;
        }
    }
}