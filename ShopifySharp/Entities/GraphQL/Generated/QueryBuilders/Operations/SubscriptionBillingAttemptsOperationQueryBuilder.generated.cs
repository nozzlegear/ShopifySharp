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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class SubscriptionBillingAttemptsOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptConnection, SubscriptionBillingAttemptsOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingAttemptConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SubscriptionBillingAttemptsArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingAttemptsOperationQueryBuilder Self => this;

        public SubscriptionBillingAttemptsOperationQueryBuilder() : this("subscriptionBillingAttempts")
        {
        }

        public SubscriptionBillingAttemptsOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptConnection>(name))
        {
            Arguments = new SubscriptionBillingAttemptsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptsOperationQueryBuilder(IQuery<SubscriptionBillingAttemptConnection> query) : base(query)
        {
            Arguments = new SubscriptionBillingAttemptsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptEdge>(query);
            return this;
        }

        public SubscriptionBillingAttemptsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public SubscriptionBillingAttemptsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}