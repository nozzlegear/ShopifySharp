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
    public sealed class SuggestedOrderTransactionQueryBuilder : FieldsQueryBuilderBase<SuggestedOrderTransaction, SuggestedOrderTransactionQueryBuilder>
    {
        protected override SuggestedOrderTransactionQueryBuilder Self => this;

        public SuggestedOrderTransactionQueryBuilder() : this("suggestedOrderTransaction")
        {
        }

        public SuggestedOrderTransactionQueryBuilder(string name) : base(new Query<SuggestedOrderTransaction>(name))
        {
        }

        public SuggestedOrderTransactionQueryBuilder(IQuery<SuggestedOrderTransaction> query) : base(query)
        {
        }

        public SuggestedOrderTransactionQueryBuilder AccountNumber()
        {
            base.InnerQuery.AddField("accountNumber");
            return this;
        }

        [Obsolete("Use `amountSet` instead.")]
        public SuggestedOrderTransactionQueryBuilder Amount()
        {
            base.InnerQuery.AddField("amount");
            return this;
        }

        public SuggestedOrderTransactionQueryBuilder AmountSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("amountSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedOrderTransactionQueryBuilder FormattedGateway()
        {
            base.InnerQuery.AddField("formattedGateway");
            return this;
        }

        public SuggestedOrderTransactionQueryBuilder Gateway()
        {
            base.InnerQuery.AddField("gateway");
            return this;
        }

        public SuggestedOrderTransactionQueryBuilder Kind()
        {
            base.InnerQuery.AddField("kind");
            return this;
        }

        [Obsolete("Use `maximumRefundableSet` instead.")]
        public SuggestedOrderTransactionQueryBuilder MaximumRefundable()
        {
            base.InnerQuery.AddField("maximumRefundable");
            return this;
        }

        public SuggestedOrderTransactionQueryBuilder MaximumRefundableSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("maximumRefundableSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public SuggestedOrderTransactionQueryBuilder ParentTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("parentTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public SuggestedOrderTransactionQueryBuilder PaymentDetails(Action<PaymentDetailsUnionCasesBuilder> build)
        {
            var query = new Query<PaymentDetails>("paymentDetails");
            var unionBuilder = new PaymentDetailsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}