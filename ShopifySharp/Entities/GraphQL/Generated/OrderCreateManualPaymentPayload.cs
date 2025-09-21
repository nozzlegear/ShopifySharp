#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `orderCreateManualPayment` mutation.
/// </summary>
public record OrderCreateManualPaymentPayload : IGraphQLObject
{
    /// <summary>
    /// The order recorded a manual payment.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OrderCreateManualPaymentOrderCreateManualPaymentError>? userErrors { get; set; } = null;
}