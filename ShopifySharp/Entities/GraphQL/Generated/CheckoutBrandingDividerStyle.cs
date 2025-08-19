#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The customizations for the page, content, main, and order summary dividers.
/// </summary>
public record CheckoutBrandingDividerStyle : IGraphQLObject
{
    /// <summary>
    /// The border style for the divider.
    /// </summary>
    [JsonPropertyName("borderStyle")]
    public CheckoutBrandingBorderStyle? borderStyle { get; set; } = null;

    /// <summary>
    /// The border width for the divider.
    /// </summary>
    [JsonPropertyName("borderWidth")]
    public CheckoutBrandingBorderWidth? borderWidth { get; set; } = null;
}