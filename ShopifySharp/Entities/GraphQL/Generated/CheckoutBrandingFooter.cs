#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A container for the footer section customizations.
/// </summary>
public record CheckoutBrandingFooter : IGraphQLObject
{
    /// <summary>
    /// The footer alignment.
    /// </summary>
    [JsonPropertyName("alignment")]
    public CheckoutBrandingFooterAlignment? alignment { get; set; } = null;

    /// <summary>
    /// The selected color scheme of the footer container.
    /// </summary>
    [JsonPropertyName("colorScheme")]
    public CheckoutBrandingColorSchemeSelection? colorScheme { get; set; } = null;

    /// <summary>
    /// The footer content settings.
    /// </summary>
    [JsonPropertyName("content")]
    public CheckoutBrandingFooterContent? content { get; set; } = null;

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
    /// The footer position.
    /// </summary>
    [JsonPropertyName("position")]
    public CheckoutBrandingFooterPosition? position { get; set; } = null;
}