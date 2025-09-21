#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A Shopify font.
/// </summary>
public record CheckoutBrandingShopifyFont : IGraphQLObject, ICheckoutBrandingFont
{
    /// <summary>
    /// The font sources.
    /// </summary>
    [JsonPropertyName("sources")]
    public string? sources { get; set; } = null;

    /// <summary>
    /// The font weight.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? weight { get; set; } = null;
}