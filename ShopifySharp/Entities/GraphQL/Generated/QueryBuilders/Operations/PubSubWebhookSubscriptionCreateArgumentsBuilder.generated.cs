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
    public sealed class PubSubWebhookSubscriptionCreateArgumentsBuilder : ArgumentsBuilderBase<PubSubWebhookSubscriptionCreatePayload, PubSubWebhookSubscriptionCreateArgumentsBuilder>
    {
        protected override PubSubWebhookSubscriptionCreateArgumentsBuilder Self => this;

        public PubSubWebhookSubscriptionCreateArgumentsBuilder(IQuery<PubSubWebhookSubscriptionCreatePayload> query) : base(query)
        {
        }

        public PubSubWebhookSubscriptionCreateArgumentsBuilder Topic(WebhookSubscriptionTopic? topic)
        {
            base.InnerQuery.AddArgument("topic", topic);
            return this;
        }

        public PubSubWebhookSubscriptionCreateArgumentsBuilder WebhookSubscription(PubSubWebhookSubscriptionInput? webhookSubscription)
        {
            base.InnerQuery.AddArgument("webhookSubscription", webhookSubscription);
            return this;
        }
    }
}