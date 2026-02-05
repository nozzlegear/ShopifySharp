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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ReturnOperationQueryBuilder : FieldsQueryBuilderBase<Return, ReturnOperationQueryBuilder>, IGraphOperationQueryBuilder<Return>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ReturnArgumentsBuilder Arguments { get; }
        protected override ReturnOperationQueryBuilder Self => this;

        public ReturnOperationQueryBuilder() : this("return")
        {
        }

        public ReturnOperationQueryBuilder(string name) : base(new Query<Return>(name))
        {
            Arguments = new ReturnArgumentsBuilder(base.InnerQuery);
        }

        public ReturnOperationQueryBuilder(IQuery<Return> query) : base(query)
        {
            Arguments = new ReturnArgumentsBuilder(base.InnerQuery);
        }

        public ReturnOperationQueryBuilder ClosedAt()
        {
            base.InnerQuery.AddField("closedAt");
            return this;
        }

        public ReturnOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ReturnOperationQueryBuilder Decline(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnDeclineQueryBuilder> build)
        {
            var query = new Query<ReturnDecline>("decline");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnDeclineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnDecline>(query);
            return this;
        }

        public ReturnOperationQueryBuilder ExchangeLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ExchangeLineItemConnection>("exchangeLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeLineItemConnection>(query);
            return this;
        }

        public ReturnOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReturnOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ReturnOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public ReturnOperationQueryBuilder Refunds(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundConnectionQueryBuilder> build)
        {
            var query = new Query<RefundConnection>("refunds");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundConnection>(query);
            return this;
        }

        public ReturnOperationQueryBuilder RequestApprovedAt()
        {
            base.InnerQuery.AddField("requestApprovedAt");
            return this;
        }

        public ReturnOperationQueryBuilder ReturnLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnLineItemTypeConnection>("returnLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnLineItemTypeConnection>(query);
            return this;
        }

        public ReturnOperationQueryBuilder ReturnShippingFees(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnShippingFeeQueryBuilder> build)
        {
            var query = new Query<ReturnShippingFee>("returnShippingFees");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnShippingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnShippingFee>(query);
            return this;
        }

        public ReturnOperationQueryBuilder ReverseFulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderConnection>("reverseFulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderConnection>(query);
            return this;
        }

        public ReturnOperationQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public ReturnOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ReturnOperationQueryBuilder SuggestedFinancialOutcome(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedReturnFinancialOutcomeQueryBuilder> build)
        {
            var query = new Query<SuggestedReturnFinancialOutcome>("suggestedFinancialOutcome");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedReturnFinancialOutcomeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedReturnFinancialOutcome>(query);
            return this;
        }

        public ReturnOperationQueryBuilder SuggestedRefund(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedReturnRefundQueryBuilder> build)
        {
            var query = new Query<SuggestedReturnRefund>("suggestedRefund");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedReturnRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedReturnRefund>(query);
            return this;
        }

        public ReturnOperationQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }

        public ReturnOperationQueryBuilder Transactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<OrderTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionConnection>(query);
            return this;
        }
    }
}