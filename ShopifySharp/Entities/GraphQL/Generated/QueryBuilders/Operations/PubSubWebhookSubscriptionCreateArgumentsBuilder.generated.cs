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