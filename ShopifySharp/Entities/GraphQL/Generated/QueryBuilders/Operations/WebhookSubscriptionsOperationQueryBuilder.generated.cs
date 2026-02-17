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
    public sealed class WebhookSubscriptionsOperationQueryBuilder : FieldsQueryBuilderBase<WebhookSubscriptionConnection, WebhookSubscriptionsOperationQueryBuilder>, IGraphOperationQueryBuilder<WebhookSubscriptionConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public WebhookSubscriptionsArgumentsBuilder Arguments { get; }
        protected override WebhookSubscriptionsOperationQueryBuilder Self => this;

        public WebhookSubscriptionsOperationQueryBuilder() : this("webhookSubscriptions")
        {
        }

        public WebhookSubscriptionsOperationQueryBuilder(string name) : base(new Query<WebhookSubscriptionConnection>(name))
        {
            Arguments = new WebhookSubscriptionsArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionsOperationQueryBuilder(IQuery<WebhookSubscriptionConnection> query) : base(query)
        {
            Arguments = new WebhookSubscriptionsArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionEdgeQueryBuilder> build)
        {
            var query = new Query<WebhookSubscriptionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscriptionEdge>(query);
            return this;
        }

        public WebhookSubscriptionsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }

        public WebhookSubscriptionsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}