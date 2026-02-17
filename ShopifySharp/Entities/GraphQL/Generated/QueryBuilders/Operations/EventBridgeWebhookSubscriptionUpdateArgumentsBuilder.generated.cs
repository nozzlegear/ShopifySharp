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