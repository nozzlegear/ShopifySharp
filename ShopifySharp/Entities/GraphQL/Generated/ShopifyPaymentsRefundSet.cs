#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Presents all Shopify Payments specific information related to an order refund.
/// </summary>
public record ShopifyPaymentsRefundSet : IGraphQLObject
{
    /// <summary>
    /// The acquirer reference number (ARN) code generated for Visa/Mastercard transactions.
    /// </summary>
    [JsonPropertyName("acquirerReferenceNumber")]
    public string? acquirerReferenceNumber { get; set; } = null;
}