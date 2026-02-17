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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class MarketCurrencySettingsQueryBuilder : FieldsQueryBuilderBase<MarketCurrencySettings, MarketCurrencySettingsQueryBuilder>
    {
        protected override MarketCurrencySettingsQueryBuilder Self => this;

        public MarketCurrencySettingsQueryBuilder() : this("marketCurrencySettings")
        {
        }

        public MarketCurrencySettingsQueryBuilder(string name) : base(new Query<MarketCurrencySettings>(name))
        {
        }

        public MarketCurrencySettingsQueryBuilder(IQuery<MarketCurrencySettings> query) : base(query)
        {
        }

        public MarketCurrencySettingsQueryBuilder BaseCurrency(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingQueryBuilder> build)
        {
            var query = new Query<CurrencySetting>("baseCurrency");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CurrencySettingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencySetting>(query);
            return this;
        }

        public MarketCurrencySettingsQueryBuilder LocalCurrencies()
        {
            base.InnerQuery.AddField("localCurrencies");
            return this;
        }

        public MarketCurrencySettingsQueryBuilder RoundingEnabled()
        {
            base.InnerQuery.AddField("roundingEnabled");
            return this;
        }
    }
}