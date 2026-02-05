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
    public sealed class WebhookSubscriptionUpdateArgumentsBuilder : ArgumentsBuilderBase<WebhookSubscriptionUpdatePayload, WebhookSubscriptionUpdateArgumentsBuilder>
    {
        protected override WebhookSubscriptionUpdateArgumentsBuilder Self => this;

        public WebhookSubscriptionUpdateArgumentsBuilder(IQuery<WebhookSubscriptionUpdatePayload> query) : base(query)
        {
        }

        public WebhookSubscriptionUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public WebhookSubscriptionUpdateArgumentsBuilder WebhookSubscription(WebhookSubscriptionInput? webhookSubscription)
        {
            base.InnerQuery.AddArgument("webhookSubscription", webhookSubscription);
            return this;
        }
    }
}