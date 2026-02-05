#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to update the main container customizations.
/// </summary>
public record CheckoutBrandingMainInput : GraphQLInputObject<CheckoutBrandingMainInput>
{
    /// <summary>
    /// The background image of the main container (must not be of SVG format).
    /// </summary>
    [JsonPropertyName("backgroundImage")]
    public CheckoutBrandingImageInput? backgroundImage { get; set; } = null;

    /// <summary>
    /// The selected color scheme for the main container of the checkout.
    /// </summary>
    [JsonPropertyName("colorScheme")]
    public CheckoutBrandingColorSchemeSelection? colorScheme { get; set; } = null;

    /// <summary>
    /// Divider style and visibility on the main container.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutBrandingContainerDividerInput? divider { get; set; } = null;

    /// <summary>
    /// The settings for the main sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutBrandingMainSectionInput? section { get; set; } = null;
}