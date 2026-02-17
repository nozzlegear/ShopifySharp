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
    public sealed class SuggestedReturnRefundQueryBuilder : FieldsQueryBuilderBase<SuggestedReturnRefund, SuggestedReturnRefundQueryBuilder>
    {
        protected override SuggestedReturnRefundQueryBuilder Self => this;

        public SuggestedReturnRefundQueryBuilder() : this("suggestedReturnRefund")
        {
        }

        public SuggestedReturnRefundQueryBuilder(string name) : base(new Query<SuggestedReturnRefund>(name))
        {
        }

        public SuggestedReturnRefundQueryBuilder(IQuery<SuggestedReturnRefund> query) : base(query)
        {
        }

        public SuggestedReturnRefundQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnRefundQueryBuilder DiscountedSubtotal(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("discountedSubtotal");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnRefundQueryBuilder MaximumRefundable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnRefundQueryBuilder RefundDuties(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder> build)
        {
            var query = new Query<RefundDuty>("refundDuties");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundDutyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundDuty>(query);
            return this;
        }

        public SuggestedReturnRefundQueryBuilder Shipping(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRefundQueryBuilder> build)
        {
            var query = new Query<ShippingRefund>("shipping");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingRefund>(query);
            return this;
        }

        public SuggestedReturnRefundQueryBuilder Subtotal(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("subtotal");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnRefundQueryBuilder SuggestedTransactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder> build)
        {
            var query = new Query<SuggestedOrderTransaction>("suggestedTransactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedOrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedOrderTransaction>(query);
            return this;
        }

        public SuggestedReturnRefundQueryBuilder TotalCartDiscountAmount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalCartDiscountAmount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnRefundQueryBuilder TotalDuties(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalDuties");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedReturnRefundQueryBuilder TotalTax(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalTax");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }
    }
}