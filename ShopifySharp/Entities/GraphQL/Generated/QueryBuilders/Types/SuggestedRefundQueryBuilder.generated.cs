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
    public sealed class SuggestedRefundQueryBuilder : FieldsQueryBuilderBase<SuggestedRefund, SuggestedRefundQueryBuilder>
    {
        protected override SuggestedRefundQueryBuilder Self => this;

        public SuggestedRefundQueryBuilder() : this("suggestedRefund")
        {
        }

        public SuggestedRefundQueryBuilder(string name) : base(new Query<SuggestedRefund>(name))
        {
        }

        public SuggestedRefundQueryBuilder(IQuery<SuggestedRefund> query) : base(query)
        {
        }

        [Obsolete("Use `amountSet` instead.")]
        public SuggestedRefundQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public SuggestedRefundQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedRefundQueryBuilder DiscountedSubtotalSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedSubtotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `maximumRefundableSet` instead.")]
        public SuggestedRefundQueryBuilder MaximumRefundable()
        {
            base.InnerQuery.AddField("maximumRefundable");
            return this;
        }

        public SuggestedRefundQueryBuilder MaximumRefundableSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundableSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedRefundQueryBuilder RefundDuties(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundDutyQueryBuilder> build)
        {
            var query = new Query<RefundDuty>("refundDuties");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundDutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundDuty>(query);
            return this;
        }

        public SuggestedRefundQueryBuilder RefundLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundLineItemQueryBuilder> build)
        {
            var query = new Query<RefundLineItem>("refundLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundLineItem>(query);
            return this;
        }

        public SuggestedRefundQueryBuilder Shipping(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingRefundQueryBuilder> build)
        {
            var query = new Query<ShippingRefund>("shipping");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShippingRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingRefund>(query);
            return this;
        }

        [Obsolete("Use `subtotalSet` instead.")]
        public SuggestedRefundQueryBuilder Subtotal()
        {
            base.InnerQuery.AddField("subtotal");
            return this;
        }

        public SuggestedRefundQueryBuilder SubtotalSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedRefundQueryBuilder SuggestedRefundMethods(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundMethodQueryBuilder> build)
        {
            var query = new Query<ISuggestedRefundMethod>("suggestedRefundMethods");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedRefundMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISuggestedRefundMethod>(query);
            return this;
        }

        public SuggestedRefundQueryBuilder SuggestedTransactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder> build)
        {
            var query = new Query<SuggestedOrderTransaction>("suggestedTransactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedOrderTransaction>(query);
            return this;
        }

        public SuggestedRefundQueryBuilder TotalCartDiscountAmountSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedRefundQueryBuilder TotalDutiesSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public SuggestedRefundQueryBuilder TotalTaxes()
        {
            base.InnerQuery.AddField("totalTaxes");
            return this;
        }

        public SuggestedRefundQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}