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
    public sealed class SubscriptionBillingCyclesOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleConnection, SubscriptionBillingCyclesOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SubscriptionBillingCyclesArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCyclesOperationQueryBuilder Self => this;

        public SubscriptionBillingCyclesOperationQueryBuilder() : this("subscriptionBillingCycles")
        {
        }

        public SubscriptionBillingCyclesOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleConnection>(name))
        {
            Arguments = new SubscriptionBillingCyclesArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCyclesOperationQueryBuilder(IQuery<SubscriptionBillingCycleConnection> query) : base(query)
        {
            Arguments = new SubscriptionBillingCyclesArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCyclesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleEdge>(query);
            return this;
        }

        public SubscriptionBillingCyclesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCyclesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}