#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The color settings for global colors and color schemes.
/// </summary>
public record CheckoutBrandingColors : IGraphQLObject
{
    /// <summary>
    /// A group of global colors for customizing the overall look and feel of the user interface.
    /// </summary>
    [JsonPropertyName("global")]
    public CheckoutBrandingColorGlobal? @global { get; set; } = null;

    /// <summary>
    /// A set of color schemes which apply to different areas of the user interface.
    /// </summary>
    [JsonPropertyName("schemes")]
    public CheckoutBrandingColorSchemes? schemes { get; set; } = null;
}