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
    public sealed class ReturnSuggestedFinancialOutcomeQueryBuilder : FieldsQueryBuilderBase<SuggestedReturnFinancialOutcome, ReturnSuggestedFinancialOutcomeQueryBuilder>, IHasArguments<ReturnSuggestedFinancialOutcomeArgumentsBuilder>
    {
        public ReturnSuggestedFinancialOutcomeArgumentsBuilder Arguments { get; }
        protected override ReturnSuggestedFinancialOutcomeQueryBuilder Self => this;

        public ReturnSuggestedFinancialOutcomeQueryBuilder(string name) : base(new Query<SuggestedReturnFinancialOutcome>(name))
        {
            Arguments = new ReturnSuggestedFinancialOutcomeArgumentsBuilder(base.InnerQuery);
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder(IQuery<SuggestedReturnFinancialOutcome> query) : base(query)
        {
            Arguments = new ReturnSuggestedFinancialOutcomeArgumentsBuilder(base.InnerQuery);
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder SetArguments(Action<ReturnSuggestedFinancialOutcomeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder DiscountedSubtotal(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedSubtotal");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder MaximumRefundable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder RefundDuties(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder> build)
        {
            var query = new Query<RefundDuty>("refundDuties");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundDuty>(query);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder Shipping(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRefundQueryBuilder> build)
        {
            var query = new Query<ShippingRefund>("shipping");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingRefund>(query);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder TotalAdditionalFees(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalAdditionalFees");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder TotalCartDiscountAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCartDiscountAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder TotalDuties(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDuties");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder TotalTax(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTax");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ReturnSuggestedFinancialOutcomeQueryBuilder FinancialTransfer(Action<ReturnOutcomeFinancialTransferUnionCasesBuilder> build)
        {
            var query = new Query<ReturnOutcomeFinancialTransfer>("financialTransfer");
            var unionBuilder = new ReturnOutcomeFinancialTransferUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}