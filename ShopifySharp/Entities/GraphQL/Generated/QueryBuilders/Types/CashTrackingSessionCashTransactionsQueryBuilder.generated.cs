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
    public sealed class CashTrackingSessionCashTransactionsQueryBuilder : FieldsQueryBuilderBase<OrderTransactionConnection, CashTrackingSessionCashTransactionsQueryBuilder>, IHasArguments<CashTrackingSessionCashTransactionsArgumentsBuilder>
    {
        public CashTrackingSessionCashTransactionsArgumentsBuilder Arguments { get; }
        protected override CashTrackingSessionCashTransactionsQueryBuilder Self => this;

        public CashTrackingSessionCashTransactionsQueryBuilder(string name) : base(new Query<OrderTransactionConnection>(name))
        {
            Arguments = new CashTrackingSessionCashTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public CashTrackingSessionCashTransactionsQueryBuilder(IQuery<OrderTransactionConnection> query) : base(query)
        {
            Arguments = new CashTrackingSessionCashTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public CashTrackingSessionCashTransactionsQueryBuilder SetArguments(Action<CashTrackingSessionCashTransactionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CashTrackingSessionCashTransactionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<OrderTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionEdge>(query);
            return this;
        }

        public CashTrackingSessionCashTransactionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public CashTrackingSessionCashTransactionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}