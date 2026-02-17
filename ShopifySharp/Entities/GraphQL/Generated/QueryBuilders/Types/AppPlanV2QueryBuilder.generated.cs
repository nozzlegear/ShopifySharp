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
    public sealed class AppPlanV2QueryBuilder : FieldsQueryBuilderBase<AppPlanV2, AppPlanV2QueryBuilder>
    {
        protected override AppPlanV2QueryBuilder Self => this;

        public AppPlanV2QueryBuilder() : this("appPlanV2")
        {
        }

        public AppPlanV2QueryBuilder(string name) : base(new Query<AppPlanV2>(name))
        {
        }

        public AppPlanV2QueryBuilder(IQuery<AppPlanV2> query) : base(query)
        {
        }

        public AppPlanV2QueryBuilder PricingDetails(Action<AppPricingDetailsUnionCasesBuilder> build)
        {
            var query = new Query<AppPricingDetails>("pricingDetails");
            var unionBuilder = new AppPricingDetailsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}