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