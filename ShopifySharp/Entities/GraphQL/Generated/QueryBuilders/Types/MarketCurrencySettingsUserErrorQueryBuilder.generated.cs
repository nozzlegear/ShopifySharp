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
    public sealed class MarketCurrencySettingsUserErrorQueryBuilder : FieldsQueryBuilderBase<MarketCurrencySettingsUserError, MarketCurrencySettingsUserErrorQueryBuilder>
    {
        protected override MarketCurrencySettingsUserErrorQueryBuilder Self => this;

        public MarketCurrencySettingsUserErrorQueryBuilder() : this("marketCurrencySettingsUserError")
        {
        }

        public MarketCurrencySettingsUserErrorQueryBuilder(string name) : base(new Query<MarketCurrencySettingsUserError>(name))
        {
        }

        public MarketCurrencySettingsUserErrorQueryBuilder(IQuery<MarketCurrencySettingsUserError> query) : base(query)
        {
        }

        public MarketCurrencySettingsUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MarketCurrencySettingsUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MarketCurrencySettingsUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}