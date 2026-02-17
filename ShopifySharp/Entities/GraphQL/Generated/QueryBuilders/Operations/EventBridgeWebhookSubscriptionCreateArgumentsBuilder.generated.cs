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
    public sealed class EventBridgeWebhookSubscriptionCreateArgumentsBuilder : ArgumentsBuilderBase<EventBridgeWebhookSubscriptionCreatePayload, EventBridgeWebhookSubscriptionCreateArgumentsBuilder>
    {
        protected override EventBridgeWebhookSubscriptionCreateArgumentsBuilder Self => this;

        public EventBridgeWebhookSubscriptionCreateArgumentsBuilder(IQuery<EventBridgeWebhookSubscriptionCreatePayload> query) : base(query)
        {
        }

        public EventBridgeWebhookSubscriptionCreateArgumentsBuilder Topic(WebhookSubscriptionTopic? topic)
        {
            base.InnerQuery.AddArgument("topic", topic);
            return this;
        }

        public EventBridgeWebhookSubscriptionCreateArgumentsBuilder WebhookSubscription(EventBridgeWebhookSubscriptionInput? webhookSubscription)
        {
            base.InnerQuery.AddArgument("webhookSubscription", webhookSubscription);
            return this;
        }
    }
}