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
/// Represents a shipping total for a Shop Pay payment request.
/// </summary>
public record ShopPayPaymentRequestTotalShippingPrice : IGraphQLObject
{
    /// <summary>
    /// The discounts for the shipping total.
    /// </summary>
    [JsonPropertyName("discounts")]
    public ICollection<ShopPayPaymentRequestDiscount>? discounts { get; set; } = null;

    /// <summary>
    /// The final total for the shipping line.
    /// </summary>
    [JsonPropertyName("finalTotal")]
    public MoneyV2? finalTotal { get; set; } = null;

    /// <summary>
    /// The original total for the shipping line.
    /// </summary>
    [JsonPropertyName("originalTotal")]
    public MoneyV2? originalTotal { get; set; } = null;
}