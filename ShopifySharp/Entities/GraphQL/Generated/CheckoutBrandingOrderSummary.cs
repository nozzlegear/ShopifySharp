#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The order summary customizations.
/// </summary>
public record CheckoutBrandingOrderSummary : IGraphQLObject
{
    /// <summary>
    /// The background image of the order summary container.
    /// </summary>
    [JsonPropertyName("backgroundImage")]
    public CheckoutBrandingImage? backgroundImage { get; set; } = null;

    /// <summary>
    /// The selected color scheme of the order summary container.
    /// </summary>
    [JsonPropertyName("colorScheme")]
    public CheckoutBrandingColorSchemeSelection? colorScheme { get; set; } = null;

    /// <summary>
    /// The order summary container's divider style and visibility.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutBrandingContainerDivider? divider { get; set; } = null;

    /// <summary>
    /// The settings for the order summary sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutBrandingOrderSummarySection? section { get; set; } = null;
}