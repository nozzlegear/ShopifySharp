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
    public sealed class SubscriptionBillingCycleBulkResultsOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleConnection, SubscriptionBillingCycleBulkResultsOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingCycleConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SubscriptionBillingCycleBulkResultsArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingCycleBulkResultsOperationQueryBuilder Self => this;

        public SubscriptionBillingCycleBulkResultsOperationQueryBuilder() : this("subscriptionBillingCycleBulkResults")
        {
        }

        public SubscriptionBillingCycleBulkResultsOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleConnection>(name))
        {
            Arguments = new SubscriptionBillingCycleBulkResultsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleBulkResultsOperationQueryBuilder(IQuery<SubscriptionBillingCycleConnection> query) : base(query)
        {
            Arguments = new SubscriptionBillingCycleBulkResultsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingCycleBulkResultsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycleEdge>(query);
            return this;
        }

        public SubscriptionBillingCycleBulkResultsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }

        public SubscriptionBillingCycleBulkResultsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}