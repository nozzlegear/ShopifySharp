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
    public sealed class SellingPlanCheckoutChargeValueUnionCasesBuilder : UnionCasesBuilderBase<SellingPlanCheckoutChargeValue, SellingPlanCheckoutChargeValueUnionCasesBuilder>
    {
        protected override SellingPlanCheckoutChargeValueUnionCasesBuilder Self => this;

        public SellingPlanCheckoutChargeValueUnionCasesBuilder(string fieldName = "sellingPlanCheckoutChargeValue") : this(new Query<SellingPlanCheckoutChargeValue>(fieldName))
        {
        }

        public SellingPlanCheckoutChargeValueUnionCasesBuilder(IQuery<SellingPlanCheckoutChargeValue> query) : base(query)
        {
        }

        public SellingPlanCheckoutChargeValueUnionCasesBuilder OnMoneyV2(Action<MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("... on MoneyV2");
            var queryBuilder = new MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SellingPlanCheckoutChargeValueUnionCasesBuilder OnSellingPlanCheckoutChargePercentageValue(Action<SellingPlanCheckoutChargePercentageValueQueryBuilder> build)
        {
            var query = new Query<SellingPlanCheckoutChargePercentageValue>("... on SellingPlanCheckoutChargePercentageValue");
            var queryBuilder = new SellingPlanCheckoutChargePercentageValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}