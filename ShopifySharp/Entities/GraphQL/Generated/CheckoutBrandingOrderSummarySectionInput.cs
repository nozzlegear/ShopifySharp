#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to update the order summary sections customizations.
/// </summary>
public record CheckoutBrandingOrderSummarySectionInput : GraphQLInputObject<CheckoutBrandingOrderSummarySectionInput>
{
    /// <summary>
    /// The background style of the order summary sections.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutBrandingBackground? background { get; set; } = null;

    /// <summary>
    /// The border for the order summary sections.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingSimpleBorder? border { get; set; } = null;

    /// <summary>
    /// The border style of the order summary sections.
    /// </summary>
    [JsonPropertyName("borderStyle")]
    public CheckoutBrandingBorderStyle? borderStyle { get; set; } = null;

    /// <summary>
    /// The border width of the order summary sections.
    /// </summary>
    [JsonPropertyName("borderWidth")]
    public CheckoutBrandingBorderWidth? borderWidth { get; set; } = null;

    /// <summary>
    /// The selected color scheme for the order summary sections.
    /// </summary>
    [JsonPropertyName("colorScheme")]
    public CheckoutBrandingColorSchemeSelection? colorScheme { get; set; } = null;

    /// <summary>
    /// The corner radius of the order summary sections.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The padding of the order summary sections.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutBrandingSpacingKeyword? padding { get; set; } = null;

    /// <summary>
    /// The shadow of the order summary sections.
    /// </summary>
    [JsonPropertyName("shadow")]
    public CheckoutBrandingShadow? shadow { get; set; } = null;
}