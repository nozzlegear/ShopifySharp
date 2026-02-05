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
    public sealed class AppPricingDetailsUnionCasesBuilder : UnionCasesBuilderBase<AppPricingDetails, AppPricingDetailsUnionCasesBuilder>
    {
        protected override AppPricingDetailsUnionCasesBuilder Self => this;

        public AppPricingDetailsUnionCasesBuilder(string fieldName = "appPricingDetails") : this(new Query<AppPricingDetails>(fieldName))
        {
        }

        public AppPricingDetailsUnionCasesBuilder(IQuery<AppPricingDetails> query) : base(query)
        {
        }

        public AppPricingDetailsUnionCasesBuilder OnAppRecurringPricing(Action<AppRecurringPricingQueryBuilder> build)
        {
            var query = new Query<AppRecurringPricing>("... on AppRecurringPricing");
            var queryBuilder = new AppRecurringPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public AppPricingDetailsUnionCasesBuilder OnAppUsagePricing(Action<AppUsagePricingQueryBuilder> build)
        {
            var query = new Query<AppUsagePricing>("... on AppUsagePricing");
            var queryBuilder = new AppUsagePricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}