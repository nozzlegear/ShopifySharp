#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The typography customizations.
/// </summary>
public record CheckoutBrandingTypographyStyle : IGraphQLObject
{
    /// <summary>
    /// The font.
    /// </summary>
    [JsonPropertyName("font")]
    public CheckoutBrandingTypographyFont? font { get; set; } = null;

    /// <summary>
    /// The kerning.
    /// </summary>
    [JsonPropertyName("kerning")]
    public CheckoutBrandingTypographyKerning? kerning { get; set; } = null;

    /// <summary>
    /// The letter case.
    /// </summary>
    [JsonPropertyName("letterCase")]
    public CheckoutBrandingTypographyLetterCase? letterCase { get; set; } = null;

    /// <summary>
    /// The font size.
    /// </summary>
    [JsonPropertyName("size")]
    public CheckoutBrandingTypographySize? size { get; set; } = null;

    /// <summary>
    /// The font weight.
    /// </summary>
    [JsonPropertyName("weight")]
    public CheckoutBrandingTypographyWeight? weight { get; set; } = null;
}