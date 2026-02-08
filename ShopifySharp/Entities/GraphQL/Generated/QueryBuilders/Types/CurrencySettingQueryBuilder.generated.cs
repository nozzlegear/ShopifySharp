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
    public sealed class CurrencySettingQueryBuilder : FieldsQueryBuilderBase<CurrencySetting, CurrencySettingQueryBuilder>
    {
        protected override CurrencySettingQueryBuilder Self => this;

        public CurrencySettingQueryBuilder() : this("currencySetting")
        {
        }

        public CurrencySettingQueryBuilder(string name) : base(new Query<CurrencySetting>(name))
        {
        }

        public CurrencySettingQueryBuilder(IQuery<CurrencySetting> query) : base(query)
        {
        }

        public CurrencySettingQueryBuilder CurrencyCode()
        {
            base.InnerQuery.AddField("currencyCode");
            return this;
        }

        public CurrencySettingQueryBuilder CurrencyName()
        {
            base.InnerQuery.AddField("currencyName");
            return this;
        }

        public CurrencySettingQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public CurrencySettingQueryBuilder ManualRate()
        {
            base.InnerQuery.AddField("manualRate");
            return this;
        }

        public CurrencySettingQueryBuilder RateUpdatedAt()
        {
            base.InnerQuery.AddField("rateUpdatedAt");
            return this;
        }
    }
}