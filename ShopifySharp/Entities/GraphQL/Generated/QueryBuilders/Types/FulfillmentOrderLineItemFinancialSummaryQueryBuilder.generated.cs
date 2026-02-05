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
    public sealed class FulfillmentOrderLineItemFinancialSummaryQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItemFinancialSummary, FulfillmentOrderLineItemFinancialSummaryQueryBuilder>
    {
        protected override FulfillmentOrderLineItemFinancialSummaryQueryBuilder Self => this;

        public FulfillmentOrderLineItemFinancialSummaryQueryBuilder() : this("fulfillmentOrderLineItemFinancialSummary")
        {
        }

        public FulfillmentOrderLineItemFinancialSummaryQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItemFinancialSummary>(name))
        {
        }

        public FulfillmentOrderLineItemFinancialSummaryQueryBuilder(IQuery<FulfillmentOrderLineItemFinancialSummary> query) : base(query)
        {
        }

        public FulfillmentOrderLineItemFinancialSummaryQueryBuilder ApproximateDiscountedUnitPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("approximateDiscountedUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FulfillmentOrderLineItemFinancialSummaryQueryBuilder DiscountAllocations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinancialSummaryDiscountAllocationQueryBuilder> build)
        {
            var query = new Query<FinancialSummaryDiscountAllocation>("discountAllocations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinancialSummaryDiscountAllocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FinancialSummaryDiscountAllocation>(query);
            return this;
        }

        public FulfillmentOrderLineItemFinancialSummaryQueryBuilder OriginalUnitPriceSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("originalUnitPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FulfillmentOrderLineItemFinancialSummaryQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }
    }
}