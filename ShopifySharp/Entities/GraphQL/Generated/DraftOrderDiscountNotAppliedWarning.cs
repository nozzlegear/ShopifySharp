#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A warning indicating that a discount cannot be applied to a draft order.
/// </summary>
public record DraftOrderDiscountNotAppliedWarning : IGraphQLObject, IDraftOrderWarning
{
    /// <summary>
    /// The code of the discount that can't be applied.
    /// </summary>
    [JsonPropertyName("discountCode")]
    public string? discountCode { get; set; } = null;

    /// <summary>
    /// The title of the discount that can't be applied.
    /// </summary>
    [JsonPropertyName("discountTitle")]
    public string? discountTitle { get; set; } = null;

    /// <summary>
    /// The error code.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string? errorCode { get; set; } = null;

    /// <summary>
    /// The input field that the warning applies to.
    /// </summary>
    [JsonPropertyName("field")]
    public string? field { get; set; } = null;

    /// <summary>
    /// The warning message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;

    /// <summary>
    /// The price rule that can't be applied.
    /// </summary>
    [JsonPropertyName("priceRule")]
    public PriceRule? priceRule { get; set; } = null;
}