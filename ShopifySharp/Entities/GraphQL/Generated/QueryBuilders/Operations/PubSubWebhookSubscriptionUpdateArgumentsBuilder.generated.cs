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
    public sealed class PubSubWebhookSubscriptionUpdateArgumentsBuilder : ArgumentsBuilderBase<PubSubWebhookSubscriptionUpdatePayload, PubSubWebhookSubscriptionUpdateArgumentsBuilder>
    {
        protected override PubSubWebhookSubscriptionUpdateArgumentsBuilder Self => this;

        public PubSubWebhookSubscriptionUpdateArgumentsBuilder(IQuery<PubSubWebhookSubscriptionUpdatePayload> query) : base(query)
        {
        }

        public PubSubWebhookSubscriptionUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public PubSubWebhookSubscriptionUpdateArgumentsBuilder WebhookSubscription(PubSubWebhookSubscriptionInput? webhookSubscription)
        {
            base.InnerQuery.AddArgument("webhookSubscription", webhookSubscription);
            return this;
        }
    }
}