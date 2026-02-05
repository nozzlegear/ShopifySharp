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
    public sealed class ReturnQueryBuilder : FieldsQueryBuilderBase<Return, ReturnQueryBuilder>
    {
        protected override ReturnQueryBuilder Self => this;

        public ReturnQueryBuilder() : this("return")
        {
        }

        public ReturnQueryBuilder(string name) : base(new Query<Return>(name))
        {
        }

        public ReturnQueryBuilder(IQuery<Return> query) : base(query)
        {
        }

        public ReturnQueryBuilder ClosedAt()
        {
            base.InnerQuery.AddField("closedAt");
            return this;
        }

        public ReturnQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ReturnQueryBuilder Decline(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnDeclineQueryBuilder> build)
        {
            var query = new Query<ReturnDecline>("decline");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnDeclineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnDecline>(query);
            return this;
        }

        public ReturnQueryBuilder ExchangeLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ExchangeLineItemConnection>("exchangeLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ExchangeLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeLineItemConnection>(query);
            return this;
        }

        public ReturnQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReturnQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ReturnQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public ReturnQueryBuilder Refunds(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundConnectionQueryBuilder> build)
        {
            var query = new Query<RefundConnection>("refunds");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundConnection>(query);
            return this;
        }

        public ReturnQueryBuilder RequestApprovedAt()
        {
            base.InnerQuery.AddField("requestApprovedAt");
            return this;
        }

        public ReturnQueryBuilder ReturnLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnLineItemTypeConnection>("returnLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnLineItemTypeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnLineItemTypeConnection>(query);
            return this;
        }

        public ReturnQueryBuilder ReturnShippingFees(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnShippingFeeQueryBuilder> build)
        {
            var query = new Query<ReturnShippingFee>("returnShippingFees");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnShippingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnShippingFee>(query);
            return this;
        }

        public ReturnQueryBuilder ReverseFulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderConnection>("reverseFulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderConnection>(query);
            return this;
        }

        public ReturnQueryBuilder StaffMember(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public ReturnQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ReturnQueryBuilder SuggestedFinancialOutcome(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedReturnFinancialOutcomeQueryBuilder> build)
        {
            var query = new Query<SuggestedReturnFinancialOutcome>("suggestedFinancialOutcome");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedReturnFinancialOutcomeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedReturnFinancialOutcome>(query);
            return this;
        }

        public ReturnQueryBuilder SuggestedRefund(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedReturnRefundQueryBuilder> build)
        {
            var query = new Query<SuggestedReturnRefund>("suggestedRefund");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SuggestedReturnRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedReturnRefund>(query);
            return this;
        }

        public ReturnQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }

        public ReturnQueryBuilder Transactions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<OrderTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionConnection>(query);
            return this;
        }
    }
}