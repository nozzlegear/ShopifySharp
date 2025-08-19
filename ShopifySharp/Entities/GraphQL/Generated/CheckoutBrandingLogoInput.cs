#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the logo customizations.
/// </summary>
public record CheckoutBrandingLogoInput : GraphQLInputObject<CheckoutBrandingLogoInput>
{
    /// <summary>
    /// The logo image (must not be of SVG format).
    /// </summary>
    [JsonPropertyName("image")]
    public CheckoutBrandingImageInput? image { get; set; } = null;

    /// <summary>
    /// The maximum width of the logo.
    /// </summary>
    [JsonPropertyName("maxWidth")]
    public int? maxWidth { get; set; } = null;

    /// <summary>
    /// The visibility of the logo.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}