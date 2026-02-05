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
    public sealed class FinancialSummaryDiscountAllocationQueryBuilder : FieldsQueryBuilderBase<FinancialSummaryDiscountAllocation, FinancialSummaryDiscountAllocationQueryBuilder>
    {
        protected override FinancialSummaryDiscountAllocationQueryBuilder Self => this;

        public FinancialSummaryDiscountAllocationQueryBuilder() : this("financialSummaryDiscountAllocation")
        {
        }

        public FinancialSummaryDiscountAllocationQueryBuilder(string name) : base(new Query<FinancialSummaryDiscountAllocation>(name))
        {
        }

        public FinancialSummaryDiscountAllocationQueryBuilder(IQuery<FinancialSummaryDiscountAllocation> query) : base(query)
        {
        }

        public FinancialSummaryDiscountAllocationQueryBuilder ApproximateAllocatedAmountPerItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("approximateAllocatedAmountPerItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FinancialSummaryDiscountAllocationQueryBuilder DiscountApplication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinancialSummaryDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<FinancialSummaryDiscountApplication>("discountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FinancialSummaryDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FinancialSummaryDiscountApplication>(query);
            return this;
        }
    }
}