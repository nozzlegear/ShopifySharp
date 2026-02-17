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
    public sealed class SellingPlanCheckoutChargeValueQueryBuilder : FieldsQueryBuilderBase<SellingPlanCheckoutChargeValue, SellingPlanCheckoutChargeValueQueryBuilder>
    {
        protected override SellingPlanCheckoutChargeValueQueryBuilder Self => this;

        public SellingPlanCheckoutChargeValueQueryBuilder() : this("sellingPlanCheckoutChargeValue")
        {
        }

        public SellingPlanCheckoutChargeValueQueryBuilder(string name) : base(new Query<SellingPlanCheckoutChargeValue>(name))
        {
        }

        public SellingPlanCheckoutChargeValueQueryBuilder(IQuery<SellingPlanCheckoutChargeValue> query) : base(query)
        {
        }

        public SellingPlanCheckoutChargeValueQueryBuilder SellingPlanCheckoutChargeValue(Action<SellingPlanCheckoutChargeValueUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanCheckoutChargeValue>("sellingPlanCheckoutChargeValue");
            var unionBuilder = new SellingPlanCheckoutChargeValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}