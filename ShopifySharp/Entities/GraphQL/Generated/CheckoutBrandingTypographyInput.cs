#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the typography. Refer to the [typography
/// tutorial](https://shopify.dev/docs/apps/checkout/styling/customize-typography)
/// for more information on how to set these fields.
/// </summary>
public record CheckoutBrandingTypographyInput : GraphQLInputObject<CheckoutBrandingTypographyInput>
{
    /// <summary>
    /// A font group used for most components such as text, buttons and form controls.
    /// </summary>
    [JsonPropertyName("primary")]
    public CheckoutBrandingFontGroupInput? primary { get; set; } = null;

    /// <summary>
    /// A font group used for heading components by default.
    /// </summary>
    [JsonPropertyName("secondary")]
    public CheckoutBrandingFontGroupInput? secondary { get; set; } = null;

    /// <summary>
    /// The font size.
    /// </summary>
    [JsonPropertyName("size")]
    public CheckoutBrandingFontSizeInput? size { get; set; } = null;
}