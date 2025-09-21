#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The typography settings used for checkout-related text. Use these settings to customize the
/// font family and size for primary and secondary text elements.
/// Refer to the [typography tutorial](https://shopify.dev/docs/apps/checkout/styling/customize-typography)
/// for further information on typography customization.
/// </summary>
public record CheckoutBrandingTypography : IGraphQLObject
{
    /// <summary>
    /// A font group used for most components such as text, buttons and form controls.
    /// </summary>
    [JsonPropertyName("primary")]
    public CheckoutBrandingFontGroup? primary { get; set; } = null;

    /// <summary>
    /// A font group used for heading components by default.
    /// </summary>
    [JsonPropertyName("secondary")]
    public CheckoutBrandingFontGroup? secondary { get; set; } = null;

    /// <summary>
    /// The font size design system (base size in pixels and scaling between different sizes).
    /// </summary>
    [JsonPropertyName("size")]
    public CheckoutBrandingFontSize? size { get; set; } = null;
}