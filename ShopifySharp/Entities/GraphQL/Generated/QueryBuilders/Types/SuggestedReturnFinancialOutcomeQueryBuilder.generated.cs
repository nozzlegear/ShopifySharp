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
    public sealed class SuggestedReturnFinancialOutcomeQueryBuilder : FieldsQueryBuilderBase<SuggestedReturnFinancialOutcome, SuggestedReturnFinancialOutcomeQueryBuilder>
    {
        protected override SuggestedReturnFinancialOutcomeQueryBuilder Self => this;

        public SuggestedReturnFinancialOutcomeQueryBuilder() : this("suggestedReturnFinancialOutcome")
        {
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder(string name) : base(new Query<SuggestedReturnFinancialOutcome>(name))
        {
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder(IQuery<SuggestedReturnFinancialOutcome> query) : base(query)
        {
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder DiscountedSubtotal(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedSubtotal");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder MaximumRefundable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder RefundDuties(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundDutyQueryBuilder> build)
        {
            var query = new Query<RefundDuty>("refundDuties");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundDutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundDuty>(query);
            return this;
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder Shipping(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingRefundQueryBuilder> build)
        {
            var query = new Query<ShippingRefund>("shipping");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingRefund>(query);
            return this;
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder TotalAdditionalFees(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalAdditionalFees");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder TotalCartDiscountAmount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCartDiscountAmount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder TotalDuties(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDuties");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder TotalTax(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTax");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnFinancialOutcomeQueryBuilder FinancialTransfer(Action<ReturnOutcomeFinancialTransferUnionCasesBuilder> build)
        {
            var query = new Query<ReturnOutcomeFinancialTransfer>("financialTransfer");
            var unionBuilder = new ReturnOutcomeFinancialTransferUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}