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
/// The Shopify font group customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingShopifyFontGroup : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The base Shopify font.
    /// </summary>
    [JsonPropertyName("base")]
    public CheckoutAndAccountsConfigurationBrandingShopifyFont? @base { get; set; } = null;

    /// <summary>
    /// The bold Shopify font.
    /// </summary>
    [JsonPropertyName("bold")]
    public CheckoutAndAccountsConfigurationBrandingShopifyFont? bold { get; set; } = null;

    /// <summary>
    /// The font loading strategy.
    /// </summary>
    [JsonPropertyName("loadingStrategy")]
    public CheckoutAndAccountsConfigurationBrandingFontLoadingStrategy? loadingStrategy { get; set; } = null;

    /// <summary>
    /// The font group name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}