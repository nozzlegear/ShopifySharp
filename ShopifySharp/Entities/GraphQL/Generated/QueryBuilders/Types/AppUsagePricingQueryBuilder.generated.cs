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
    public sealed class AppUsagePricingQueryBuilder : FieldsQueryBuilderBase<AppUsagePricing, AppUsagePricingQueryBuilder>
    {
        protected override AppUsagePricingQueryBuilder Self => this;

        public AppUsagePricingQueryBuilder() : this("appUsagePricing")
        {
        }

        public AppUsagePricingQueryBuilder(string name) : base(new Query<AppUsagePricing>(name))
        {
        }

        public AppUsagePricingQueryBuilder(IQuery<AppUsagePricing> query) : base(query)
        {
        }

        public AppUsagePricingQueryBuilder BalanceUsed(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balanceUsed");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public AppUsagePricingQueryBuilder CappedAmount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("cappedAmount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public AppUsagePricingQueryBuilder Interval()
        {
            base.InnerQuery.AddField("interval");
            return this;
        }

        public AppUsagePricingQueryBuilder Terms()
        {
            base.InnerQuery.AddField("terms");
            return this;
        }
    }
}