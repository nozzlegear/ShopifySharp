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
    public sealed class MarketRegionCountryQueryBuilder : FieldsQueryBuilderBase<MarketRegionCountry, MarketRegionCountryQueryBuilder>
    {
        protected override MarketRegionCountryQueryBuilder Self => this;

        public MarketRegionCountryQueryBuilder() : this("marketRegionCountry")
        {
        }

        public MarketRegionCountryQueryBuilder(string name) : base(new Query<MarketRegionCountry>(name))
        {
        }

        public MarketRegionCountryQueryBuilder(IQuery<MarketRegionCountry> query) : base(query)
        {
        }

        public MarketRegionCountryQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MarketRegionCountryQueryBuilder Currency(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencySettingQueryBuilder> build)
        {
            var query = new Query<CurrencySetting>("currency");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CurrencySettingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CurrencySetting>(query);
            return this;
        }

        public MarketRegionCountryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketRegionCountryQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}