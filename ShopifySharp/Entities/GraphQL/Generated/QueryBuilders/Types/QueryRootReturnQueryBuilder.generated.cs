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
    public sealed class QueryRootReturnQueryBuilder : FieldsQueryBuilderBase<Return, QueryRootReturnQueryBuilder>, IHasArguments<QueryRootReturnArgumentsBuilder>
    {
        public QueryRootReturnArgumentsBuilder Arguments { get; }
        protected override QueryRootReturnQueryBuilder Self => this;

        public QueryRootReturnQueryBuilder(string name) : base(new Query<Return>(name))
        {
            Arguments = new QueryRootReturnArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReturnQueryBuilder(IQuery<Return> query) : base(query)
        {
            Arguments = new QueryRootReturnArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootReturnQueryBuilder SetArguments(Action<QueryRootReturnArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootReturnQueryBuilder ClosedAt()
        {
            base.InnerQuery.AddField("closedAt");
            return this;
        }

        public QueryRootReturnQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootReturnQueryBuilder Decline(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnDeclineQueryBuilder> build)
        {
            var query = new Query<ReturnDecline>("decline");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnDeclineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnDecline>(query);
            return this;
        }

        public QueryRootReturnQueryBuilder ExchangeLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ExchangeLineItemConnection>("exchangeLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeLineItemConnection>(query);
            return this;
        }

        public QueryRootReturnQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootReturnQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootReturnQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootReturnQueryBuilder Refunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundConnectionQueryBuilder> build)
        {
            var query = new Query<RefundConnection>("refunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundConnection>(query);
            return this;
        }

        public QueryRootReturnQueryBuilder RequestApprovedAt()
        {
            base.InnerQuery.AddField("requestApprovedAt");
            return this;
        }

        public QueryRootReturnQueryBuilder ReturnLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemTypeConnectionQueryBuilder> build)
        {
            var query = new Query<ReturnLineItemTypeConnection>("returnLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemTypeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnLineItemTypeConnection>(query);
            return this;
        }

        public QueryRootReturnQueryBuilder ReturnShippingFees(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnShippingFeeQueryBuilder> build)
        {
            var query = new Query<ReturnShippingFee>("returnShippingFees");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnShippingFeeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnShippingFee>(query);
            return this;
        }

        public QueryRootReturnQueryBuilder ReverseFulfillmentOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderConnection>("reverseFulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderConnection>(query);
            return this;
        }

        public QueryRootReturnQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootReturnQueryBuilder SuggestedFinancialOutcome(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedReturnFinancialOutcomeQueryBuilder> build)
        {
            var query = new Query<SuggestedReturnFinancialOutcome>("suggestedFinancialOutcome");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedReturnFinancialOutcomeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedReturnFinancialOutcome>(query);
            return this;
        }

        public QueryRootReturnQueryBuilder SuggestedRefund(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedReturnRefundQueryBuilder> build)
        {
            var query = new Query<SuggestedReturnRefund>("suggestedRefund");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SuggestedReturnRefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SuggestedReturnRefund>(query);
            return this;
        }

        public QueryRootReturnQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }
    }
}