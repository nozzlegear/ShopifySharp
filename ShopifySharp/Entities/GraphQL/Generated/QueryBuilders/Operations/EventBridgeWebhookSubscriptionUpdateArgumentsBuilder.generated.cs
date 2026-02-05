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
    public sealed class EventBridgeWebhookSubscriptionUpdateArgumentsBuilder : ArgumentsBuilderBase<EventBridgeWebhookSubscriptionUpdatePayload, EventBridgeWebhookSubscriptionUpdateArgumentsBuilder>
    {
        protected override EventBridgeWebhookSubscriptionUpdateArgumentsBuilder Self => this;

        public EventBridgeWebhookSubscriptionUpdateArgumentsBuilder(IQuery<EventBridgeWebhookSubscriptionUpdatePayload> query) : base(query)
        {
        }

        public EventBridgeWebhookSubscriptionUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public EventBridgeWebhookSubscriptionUpdateArgumentsBuilder WebhookSubscription(EventBridgeWebhookSubscriptionInput? webhookSubscription)
        {
            base.InnerQuery.AddArgument("webhookSubscription", webhookSubscription);
            return this;
        }
    }
}