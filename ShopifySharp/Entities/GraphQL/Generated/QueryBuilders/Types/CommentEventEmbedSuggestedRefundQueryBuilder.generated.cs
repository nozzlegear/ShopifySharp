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
    public sealed class CommentEventEmbedSuggestedRefundQueryBuilder : FieldsQueryBuilderBase<SuggestedRefund, CommentEventEmbedSuggestedRefundQueryBuilder>, IHasArguments<CommentEventEmbedSuggestedRefundArgumentsBuilder>
    {
        public CommentEventEmbedSuggestedRefundArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedSuggestedRefundQueryBuilder Self => this;

        public CommentEventEmbedSuggestedRefundQueryBuilder(string name) : base(new Query<SuggestedRefund>(name))
        {
            Arguments = new CommentEventEmbedSuggestedRefundArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder(IQuery<SuggestedRefund> query) : base(query)
        {
            Arguments = new CommentEventEmbedSuggestedRefundArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder SetArguments(Action<CommentEventEmbedSuggestedRefundArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        [Obsolete("Use `amountSet` instead.")]
        public CommentEventEmbedSuggestedRefundQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder DiscountedSubtotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedSubtotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `maximumRefundableSet` instead.")]
        public CommentEventEmbedSuggestedRefundQueryBuilder MaximumRefundable()
        {
            base.InnerQuery.AddField("maximumRefundable");
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder MaximumRefundableSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundableSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder RefundDuties(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder> build)
        {
            var query = new Query<RefundDuty>("refundDuties");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundDuty>(query);
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder RefundLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemQueryBuilder> build)
        {
            var query = new Query<RefundLineItem>("refundLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundLineItem>(query);
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder Shipping(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRefundQueryBuilder> build)
        {
            var query = new Query<ShippingRefund>("shipping");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingRefund>(query);
            return this;
        }

        [Obsolete("Use `subtotalSet` instead.")]
        public CommentEventEmbedSuggestedRefundQueryBuilder Subtotal()
        {
            base.InnerQuery.AddField("subtotal");
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder SubtotalSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotalSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder SuggestedTransactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder> build)
        {
            var query = new Query<SuggestedOrderTransaction>("suggestedTransactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedOrderTransaction>(query);
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder TotalCartDiscountAmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCartDiscountAmountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder TotalDutiesSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDutiesSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        [Obsolete("Use `totalTaxSet` instead.")]
        public CommentEventEmbedSuggestedRefundQueryBuilder TotalTaxes()
        {
            base.InnerQuery.AddField("totalTaxes");
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder TotalTaxSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTaxSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public CommentEventEmbedSuggestedRefundQueryBuilder SuggestedRefundMethods(Action<SuggestedRefundMethodInterfaceCasesBuilder> build)
        {
            var query = new Query<ISuggestedRefundMethod>("suggestedRefundMethods");
            var unionBuilder = new SuggestedRefundMethodInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}