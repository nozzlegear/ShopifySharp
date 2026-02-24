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
    public sealed class OrderSuggestedRefundQueryBuilder : FieldsQueryBuilderBase<SuggestedRefund, OrderSuggestedRefundQueryBuilder>, IHasArguments<OrderSuggestedRefundArgumentsBuilder>
    {
        public OrderSuggestedRefundArgumentsBuilder Arguments { get; }
        protected override OrderSuggestedRefundQueryBuilder Self => this;

        public OrderSuggestedRefundQueryBuilder(string name) : base(new Query<SuggestedRefund>(name))
        {
            Arguments = new OrderSuggestedRefundArgumentsBuilder(base.InnerQuery);
        }

        public OrderSuggestedRefundQueryBuilder(IQuery<SuggestedRefund> query) : base(query)
        {
            Arguments = new OrderSuggestedRefundArgumentsBuilder(base.InnerQuery);
        }

        public OrderSuggestedRefundQueryBuilder SetArguments(Action<OrderSuggestedRefundArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        [Obsolete("Use `amountSet` instead.")]
        public OrderSuggestedRefundQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public OrderSuggestedRefundQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderSuggestedRefundQueryBuilder DiscountedSubtotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedSubtotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `maximumRefundableSet` instead.")]
        public OrderSuggestedRefundQueryBuilder MaximumRefundable()
        {
            base.InnerQuery.AddField("maximumRefundable");
            return this;
        }

        public OrderSuggestedRefundQueryBuilder MaximumRefundableSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundableSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderSuggestedRefundQueryBuilder RefundDuties(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder> build)
        {
            var query = new Query<RefundDuty>("refundDuties");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundDuty>(query);
            return this;
        }

        public OrderSuggestedRefundQueryBuilder RefundLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemQueryBuilder> build)
        {
            var query = new Query<RefundLineItem>("refundLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundLineItem>(query);
            return this;
        }

        public OrderSuggestedRefundQueryBuilder Shipping(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRefundQueryBuilder> build)
        {
            var query = new Query<ShippingRefund>("shipping");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingRefund>(query);
            return this;
        }

        [Obsolete("Use `subtotalSet` instead.")]
        public OrderSuggestedRefundQueryBuilder Subtotal()
        {
            base.InnerQuery.AddField("subtotal");
            return this;
        }

        public OrderSuggestedRefundQueryBuilder SubtotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderSuggestedRefundQueryBuilder SuggestedRefundMethods(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedRefundMethodQueryBuilder> build)
        {
            var query = new Query<ISuggestedRefundMethod>("suggestedRefundMethods");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedRefundMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISuggestedRefundMethod>(query);
            return this;
        }

        public OrderSuggestedRefundQueryBuilder SuggestedTransactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder> build)
        {
            var query = new Query<SuggestedOrderTransaction>("suggestedTransactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedOrderTransaction>(query);
            return this;
        }

        public OrderSuggestedRefundQueryBuilder TotalCartDiscountAmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public OrderSuggestedRefundQueryBuilder TotalDutiesSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public OrderSuggestedRefundQueryBuilder TotalTaxes()
        {
            base.InnerQuery.AddField("totalTaxes");
            return this;
        }

        public OrderSuggestedRefundQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}