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
    public sealed class SubscriptionBillingAttemptTransactionsQueryBuilder : FieldsQueryBuilderBase<OrderTransactionConnection, SubscriptionBillingAttemptTransactionsQueryBuilder>, IHasArguments<SubscriptionBillingAttemptTransactionsArgumentsBuilder>
    {
        public SubscriptionBillingAttemptTransactionsArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingAttemptTransactionsQueryBuilder Self => this;

        public SubscriptionBillingAttemptTransactionsQueryBuilder(string name) : base(new Query<OrderTransactionConnection>(name))
        {
            Arguments = new SubscriptionBillingAttemptTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptTransactionsQueryBuilder(IQuery<OrderTransactionConnection> query) : base(query)
        {
            Arguments = new SubscriptionBillingAttemptTransactionsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptTransactionsQueryBuilder SetArguments(Action<SubscriptionBillingAttemptTransactionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionBillingAttemptTransactionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<OrderTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionEdge>(query);
            return this;
        }

        public SubscriptionBillingAttemptTransactionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public SubscriptionBillingAttemptTransactionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}