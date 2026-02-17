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

        public FinancialSummaryDiscountAllocationQueryBuilder ApproximateAllocatedAmountPerItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("approximateAllocatedAmountPerItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public FinancialSummaryDiscountAllocationQueryBuilder DiscountApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FinancialSummaryDiscountApplicationQueryBuilder> build)
        {
            var query = new Query<FinancialSummaryDiscountApplication>("discountApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FinancialSummaryDiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FinancialSummaryDiscountApplication>(query);
            return this;
        }
    }
}