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
/// The main container customizations.
/// </summary>
public record CheckoutBrandingMain : IGraphQLObject
{
    /// <summary>
    /// The background image of the main container.
    /// </summary>
    [JsonPropertyName("backgroundImage")]
    public CheckoutBrandingImage? backgroundImage { get; set; } = null;

    /// <summary>
    /// The selected color scheme of the main container.
    /// </summary>
    [JsonPropertyName("colorScheme")]
    public CheckoutBrandingColorSchemeSelection? colorScheme { get; set; } = null;

    /// <summary>
    /// The main container's divider style and visibility.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutBrandingContainerDivider? divider { get; set; } = null;

    /// <summary>
    /// The settings for the main sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutBrandingMainSection? section { get; set; } = null;
}