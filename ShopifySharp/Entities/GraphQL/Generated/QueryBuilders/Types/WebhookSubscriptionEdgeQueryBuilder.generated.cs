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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class WebhookSubscriptionEdgeQueryBuilder : FieldsQueryBuilderBase<WebhookSubscriptionEdge, WebhookSubscriptionEdgeQueryBuilder>
    {
        protected override WebhookSubscriptionEdgeQueryBuilder Self => this;

        public WebhookSubscriptionEdgeQueryBuilder() : this("webhookSubscriptionEdge")
        {
        }

        public WebhookSubscriptionEdgeQueryBuilder(string name) : base(new Query<WebhookSubscriptionEdge>(name))
        {
        }

        public WebhookSubscriptionEdgeQueryBuilder(IQuery<WebhookSubscriptionEdge> query) : base(query)
        {
        }

        public WebhookSubscriptionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public WebhookSubscriptionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}