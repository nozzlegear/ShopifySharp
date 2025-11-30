#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class WebhookSubscriptionUpdateQueryBuilder() : GraphQueryBuilder<WebhookSubscriptionUpdatePayload>("webhookSubscriptionUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public WebhookSubscriptionUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public WebhookSubscriptionUpdateQueryBuilder AddArgumentWebhookSubscription(WebhookSubscriptionInput? webhookSubscription)
    {
        AddArgument("webhookSubscription", webhookSubscription);
        return this;
    }
}