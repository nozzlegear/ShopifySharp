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
    public sealed class FinancialSummaryDiscountApplicationQueryBuilder : FieldsQueryBuilderBase<FinancialSummaryDiscountApplication, FinancialSummaryDiscountApplicationQueryBuilder>
    {
        protected override FinancialSummaryDiscountApplicationQueryBuilder Self => this;

        public FinancialSummaryDiscountApplicationQueryBuilder() : this("financialSummaryDiscountApplication")
        {
        }

        public FinancialSummaryDiscountApplicationQueryBuilder(string name) : base(new Query<FinancialSummaryDiscountApplication>(name))
        {
        }

        public FinancialSummaryDiscountApplicationQueryBuilder(IQuery<FinancialSummaryDiscountApplication> query) : base(query)
        {
        }

        public FinancialSummaryDiscountApplicationQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public FinancialSummaryDiscountApplicationQueryBuilder TargetSelection()
        {
            base.InnerQuery.AddField("targetSelection");
            return this;
        }

        public FinancialSummaryDiscountApplicationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }
    }
}