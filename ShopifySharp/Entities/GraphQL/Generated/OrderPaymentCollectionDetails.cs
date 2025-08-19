#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The payment collection details for an order that requires additional payment following an edit to the order.
/// </summary>
public record OrderPaymentCollectionDetails : IGraphQLObject
{
    /// <summary>
    /// The URL to use for collecting an additional payment on the order.
    /// </summary>
    [JsonPropertyName("additionalPaymentCollectionUrl")]
    public string? additionalPaymentCollectionUrl { get; set; } = null;

    /// <summary>
    /// The list of vaulted payment methods for the order with their permissions.
    /// </summary>
    [JsonPropertyName("vaultedPaymentMethods")]
    public ICollection<PaymentMandate>? vaultedPaymentMethods { get; set; } = null;
}