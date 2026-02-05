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
/// The main sections customizations.
/// </summary>
public record CheckoutBrandingMainSection : IGraphQLObject
{
    /// <summary>
    /// The background style of the main sections.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutBrandingBackground? background { get; set; } = null;

    /// <summary>
    /// The border for the main sections.
    /// </summary>
    [JsonPropertyName("border")]
    public CheckoutBrandingSimpleBorder? border { get; set; } = null;

    /// <summary>
    /// The border style of the main sections.
    /// </summary>
    [JsonPropertyName("borderStyle")]
    public CheckoutBrandingBorderStyle? borderStyle { get; set; } = null;

    /// <summary>
    /// The border width of the main sections.
    /// </summary>
    [JsonPropertyName("borderWidth")]
    public CheckoutBrandingBorderWidth? borderWidth { get; set; } = null;

    /// <summary>
    /// The selected color scheme of the main sections.
    /// </summary>
    [JsonPropertyName("colorScheme")]
    public CheckoutBrandingColorSchemeSelection? colorScheme { get; set; } = null;

    /// <summary>
    /// The corner radius of the main sections.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;

    /// <summary>
    /// The padding of the main sections.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutBrandingSpacingKeyword? padding { get; set; } = null;

    /// <summary>
    /// The shadow of the main sections.
    /// </summary>
    [JsonPropertyName("shadow")]
    public CheckoutBrandingShadow? shadow { get; set; } = null;
}