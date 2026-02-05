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
    public sealed class ShopifyPaymentsBalanceTransactionQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsBalanceTransaction, ShopifyPaymentsBalanceTransactionQueryBuilder>
    {
        protected override ShopifyPaymentsBalanceTransactionQueryBuilder Self => this;

        public ShopifyPaymentsBalanceTransactionQueryBuilder() : this("shopifyPaymentsBalanceTransaction")
        {
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder(string name) : base(new Query<ShopifyPaymentsBalanceTransaction>(name))
        {
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder(IQuery<ShopifyPaymentsBalanceTransaction> query) : base(query)
        {
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder AdjustmentReason()
        {
            base.InnerQuery.AddField("adjustmentReason");
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder AdjustmentsOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAdjustmentOrderQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAdjustmentOrder>("adjustmentsOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAdjustmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsAdjustmentOrder>(query);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder AssociatedOrder(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAssociatedOrderQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAssociatedOrder>("associatedOrder");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsAssociatedOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsAssociatedOrder>(query);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder AssociatedPayout(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBalanceTransactionAssociatedPayout>("associatedPayout");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBalanceTransactionAssociatedPayout>(query);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder Fee(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("fee");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder Net(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("net");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder SourceId()
        {
            base.InnerQuery.AddField("sourceId");
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder SourceOrderTransactionId()
        {
            base.InnerQuery.AddField("sourceOrderTransactionId");
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder SourceType()
        {
            base.InnerQuery.AddField("sourceType");
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder TransactionDate()
        {
            base.InnerQuery.AddField("transactionDate");
            return this;
        }

        public ShopifyPaymentsBalanceTransactionQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}