#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the order summary container customizations.
/// </summary>
public record CheckoutBrandingOrderSummaryInput : GraphQLInputObject<CheckoutBrandingOrderSummaryInput>
{
    /// <summary>
    /// The background image of the order summary container (must not be of SVG format).
    /// </summary>
    [JsonPropertyName("backgroundImage")]
    public CheckoutBrandingImageInput? backgroundImage { get; set; } = null;

    /// <summary>
    /// The selected color scheme for the order summary container of the checkout.
    /// </summary>
    [JsonPropertyName("colorScheme")]
    public CheckoutBrandingColorSchemeSelection? colorScheme { get; set; } = null;

    /// <summary>
    /// Divider style and visibility on the order summary container.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutBrandingContainerDividerInput? divider { get; set; } = null;

    /// <summary>
    /// The settings for the order summary sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutBrandingOrderSummarySectionInput? section { get; set; } = null;
}