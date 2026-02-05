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
    public sealed class MarketCurrencySettingsUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<MarketCurrencySettingsUpdatePayload, MarketCurrencySettingsUpdatePayloadQueryBuilder>
    {
        protected override MarketCurrencySettingsUpdatePayloadQueryBuilder Self => this;

        public MarketCurrencySettingsUpdatePayloadQueryBuilder() : this("marketCurrencySettingsUpdatePayload")
        {
        }

        public MarketCurrencySettingsUpdatePayloadQueryBuilder(string name) : base(new Query<MarketCurrencySettingsUpdatePayload>(name))
        {
        }

        public MarketCurrencySettingsUpdatePayloadQueryBuilder(IQuery<MarketCurrencySettingsUpdatePayload> query) : base(query)
        {
        }

        public MarketCurrencySettingsUpdatePayloadQueryBuilder Market(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketCurrencySettingsUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCurrencySettingsUserErrorQueryBuilder> build)
        {
            var query = new Query<MarketCurrencySettingsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketCurrencySettingsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCurrencySettingsUserError>(query);
            return this;
        }
    }
}