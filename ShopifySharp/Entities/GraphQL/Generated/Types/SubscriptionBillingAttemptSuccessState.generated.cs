#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The billing attempt completed successfully and created an order.
/// </summary>
public record SubscriptionBillingAttemptSuccessState : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The order created by the successful billing attempt. May be null if the order was deleted.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;
}