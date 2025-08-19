#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to update a custom font group.
/// </summary>
public record CheckoutBrandingCustomFontGroupInput : GraphQLInputObject<CheckoutBrandingCustomFontGroupInput>
{
    /// <summary>
    /// The base font.
    /// </summary>
    [JsonPropertyName("base")]
    public CheckoutBrandingCustomFontInput? @base { get; set; } = null;

    /// <summary>
    /// The bold font.
    /// </summary>
    [JsonPropertyName("bold")]
    public CheckoutBrandingCustomFontInput? bold { get; set; } = null;

    /// <summary>
    /// The font loading strategy.
    /// </summary>
    [JsonPropertyName("loadingStrategy")]
    public CheckoutBrandingFontLoadingStrategy? loadingStrategy { get; set; } = null;
}