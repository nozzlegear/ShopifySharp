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
/// The header customizations.
/// </summary>
public record CheckoutBrandingHeader : IGraphQLObject
{
    /// <summary>
    /// The header alignment.
    /// </summary>
    [JsonPropertyName("alignment")]
    public CheckoutBrandingHeaderAlignment? alignment { get; set; } = null;

    /// <summary>
    /// The background image of the header.
    /// </summary>
    [JsonPropertyName("banner")]
    public CheckoutBrandingImage? banner { get; set; } = null;

    /// <summary>
    /// The cart link customizations for 1-page checkout. This field allows to
    /// customize the cart icon that renders by default on 1-page checkout.
    /// </summary>
    [JsonPropertyName("cartLink")]
    public CheckoutBrandingHeaderCartLink? cartLink { get; set; } = null;

    /// <summary>
    /// The selected color scheme of the header container.
    /// </summary>
    [JsonPropertyName("colorScheme")]
    public CheckoutBrandingColorSchemeSelection? colorScheme { get; set; } = null;

    /// <summary>
    /// The divided setting.
    /// </summary>
    [JsonPropertyName("divided")]
    public bool? divided { get; set; } = null;

    /// <summary>
    /// The store logo.
    /// </summary>
    [JsonPropertyName("logo")]
    public CheckoutBrandingLogo? logo { get; set; } = null;

    /// <summary>
    /// The padding of the header container.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutBrandingSpacingKeyword? padding { get; set; } = null;

    /// <summary>
    /// The header position.
    /// </summary>
    [JsonPropertyName("position")]
    public CheckoutBrandingHeaderPosition? position { get; set; } = null;
}