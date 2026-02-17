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
    public sealed class WebhookSubscriptionConnectionQueryBuilder : FieldsQueryBuilderBase<WebhookSubscriptionConnection, WebhookSubscriptionConnectionQueryBuilder>
    {
        protected override WebhookSubscriptionConnectionQueryBuilder Self => this;

        public WebhookSubscriptionConnectionQueryBuilder() : this("webhookSubscriptionConnection")
        {
        }

        public WebhookSubscriptionConnectionQueryBuilder(string name) : base(new Query<WebhookSubscriptionConnection>(name))
        {
        }

        public WebhookSubscriptionConnectionQueryBuilder(IQuery<WebhookSubscriptionConnection> query) : base(query)
        {
        }

        public WebhookSubscriptionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionEdgeQueryBuilder> build)
        {
            var query = new Query<WebhookSubscriptionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscriptionEdge>(query);
            return this;
        }

        public WebhookSubscriptionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }

        public WebhookSubscriptionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}