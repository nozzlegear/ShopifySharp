#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Presents all Shopify Payments specific information related to an order transaction.
/// </summary>
public record ShopifyPaymentsTransactionSet : IGraphQLObject
{
    /// <summary>
    /// Contains all fields related to an extended authorization.
    /// </summary>
    [JsonPropertyName("extendedAuthorizationSet")]
    public ShopifyPaymentsExtendedAuthorization? extendedAuthorizationSet { get; set; } = null;

    /// <summary>
    /// Contains all fields related to a refund.
    /// </summary>
    [JsonPropertyName("refundSet")]
    public ShopifyPaymentsRefundSet? refundSet { get; set; } = null;
}