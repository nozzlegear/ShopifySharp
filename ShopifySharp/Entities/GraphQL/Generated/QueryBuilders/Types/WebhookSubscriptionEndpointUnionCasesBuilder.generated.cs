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
    public sealed class WebhookSubscriptionEndpointUnionCasesBuilder : UnionCasesBuilderBase<WebhookSubscriptionEndpoint, WebhookSubscriptionEndpointUnionCasesBuilder>
    {
        protected override WebhookSubscriptionEndpointUnionCasesBuilder Self => this;

        public WebhookSubscriptionEndpointUnionCasesBuilder(string fieldName = "webhookSubscriptionEndpoint") : this(new Query<WebhookSubscriptionEndpoint>(fieldName))
        {
        }

        public WebhookSubscriptionEndpointUnionCasesBuilder(IQuery<WebhookSubscriptionEndpoint> query) : base(query)
        {
        }

        public WebhookSubscriptionEndpointUnionCasesBuilder OnWebhookEventBridgeEndpoint(Action<WebhookEventBridgeEndpointQueryBuilder> build)
        {
            var query = new Query<WebhookEventBridgeEndpoint>("... on WebhookEventBridgeEndpoint");
            var queryBuilder = new WebhookEventBridgeEndpointQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public WebhookSubscriptionEndpointUnionCasesBuilder OnWebhookHttpEndpoint(Action<WebhookHttpEndpointQueryBuilder> build)
        {
            var query = new Query<WebhookHttpEndpoint>("... on WebhookHttpEndpoint");
            var queryBuilder = new WebhookHttpEndpointQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public WebhookSubscriptionEndpointUnionCasesBuilder OnWebhookPubSubEndpoint(Action<WebhookPubSubEndpointQueryBuilder> build)
        {
            var query = new Query<WebhookPubSubEndpoint>("... on WebhookPubSubEndpoint");
            var queryBuilder = new WebhookPubSubEndpointQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}