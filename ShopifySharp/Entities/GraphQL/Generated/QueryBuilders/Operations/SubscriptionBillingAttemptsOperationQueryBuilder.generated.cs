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

        public SubscriptionBillingAttemptsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptEdge>(query);
            return this;
        }

        public SubscriptionBillingAttemptsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public SubscriptionBillingAttemptsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}