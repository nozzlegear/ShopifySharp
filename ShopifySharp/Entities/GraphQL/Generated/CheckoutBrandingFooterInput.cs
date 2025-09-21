#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields when mutating the checkout footer settings.
/// </summary>
public record CheckoutBrandingFooterInput : GraphQLInputObject<CheckoutBrandingFooterInput>
{
    /// <summary>
    /// The footer alignment settings. You can set the footer native content alignment to the left, center, or right.
    /// </summary>
    [JsonPropertyName("alignment")]
    public CheckoutBrandingFooterAlignment? alignment { get; set; } = null;

    /// <summary>
    /// The selected color scheme of the footer container.
    /// </summary>
    [JsonPropertyName("colorScheme")]
    public CheckoutBrandingColorSchemeSelection? colorScheme { get; set; } = null;

    /// <summary>
    /// The input field for setting the footer content customizations.
    /// </summary>
    [JsonPropertyName("content")]
    public CheckoutBrandingFooterContentInput? content { get; set; } = null;

    /// <summary>
    /// The divided setting.
    /// </summary>
    [JsonPropertyName("divided")]
    public bool? divided { get; set; } = null;

    /// <summary>
    /// The padding of the footer container.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutBrandingSpacingKeyword? padding { get; set; } = null;

    /// <summary>
    /// The input field for setting the footer position customizations.
    /// </summary>
    [JsonPropertyName("position")]
    public CheckoutBrandingFooterPosition? position { get; set; } = null;
}