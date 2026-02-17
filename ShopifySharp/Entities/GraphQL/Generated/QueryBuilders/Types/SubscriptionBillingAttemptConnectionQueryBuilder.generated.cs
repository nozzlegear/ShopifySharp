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
    public sealed class SubscriptionBillingAttemptConnectionQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptConnection, SubscriptionBillingAttemptConnectionQueryBuilder>
    {
        protected override SubscriptionBillingAttemptConnectionQueryBuilder Self => this;

        public SubscriptionBillingAttemptConnectionQueryBuilder() : this("subscriptionBillingAttemptConnection")
        {
        }

        public SubscriptionBillingAttemptConnectionQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptConnection>(name))
        {
        }

        public SubscriptionBillingAttemptConnectionQueryBuilder(IQuery<SubscriptionBillingAttemptConnection> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttemptEdge>(query);
            return this;
        }

        public SubscriptionBillingAttemptConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public SubscriptionBillingAttemptConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}