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
    public sealed class AppRecurringPricingQueryBuilder : FieldsQueryBuilderBase<AppRecurringPricing, AppRecurringPricingQueryBuilder>
    {
        protected override AppRecurringPricingQueryBuilder Self => this;

        public AppRecurringPricingQueryBuilder() : this("appRecurringPricing")
        {
        }

        public AppRecurringPricingQueryBuilder(string name) : base(new Query<AppRecurringPricing>(name))
        {
        }

        public AppRecurringPricingQueryBuilder(IQuery<AppRecurringPricing> query) : base(query)
        {
        }

        public AppRecurringPricingQueryBuilder Discount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionDiscountQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionDiscount>("discount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionDiscountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscriptionDiscount>(query);
            return this;
        }

        public AppRecurringPricingQueryBuilder Interval()
        {
            base.InnerQuery.AddField("interval");
            return this;
        }

        public AppRecurringPricingQueryBuilder PlanHandle()
        {
            base.InnerQuery.AddField("planHandle");
            return this;
        }

        public AppRecurringPricingQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}