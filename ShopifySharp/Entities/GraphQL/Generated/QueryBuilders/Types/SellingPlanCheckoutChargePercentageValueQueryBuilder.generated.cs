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