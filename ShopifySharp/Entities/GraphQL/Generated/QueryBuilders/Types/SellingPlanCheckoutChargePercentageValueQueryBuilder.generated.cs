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
    public sealed class SellingPlanCheckoutChargePercentageValueQueryBuilder : FieldsQueryBuilderBase<SellingPlanCheckoutChargePercentageValue, SellingPlanCheckoutChargePercentageValueQueryBuilder>
    {
        protected override SellingPlanCheckoutChargePercentageValueQueryBuilder Self => this;

        public SellingPlanCheckoutChargePercentageValueQueryBuilder() : this("sellingPlanCheckoutChargePercentageValue")
        {
        }

        public SellingPlanCheckoutChargePercentageValueQueryBuilder(string name) : base(new Query<SellingPlanCheckoutChargePercentageValue>(name))
        {
        }

        public SellingPlanCheckoutChargePercentageValueQueryBuilder(IQuery<SellingPlanCheckoutChargePercentageValue> query) : base(query)
        {
        }

        public SellingPlanCheckoutChargePercentageValueQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}