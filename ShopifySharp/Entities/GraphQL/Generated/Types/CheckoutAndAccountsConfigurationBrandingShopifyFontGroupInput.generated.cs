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
/// The input fields for customizing a Shopify font group.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingShopifyFontGroupInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingShopifyFontGroupInput>
{
    /// <summary>
    /// The Shopify base font handle.
    /// </summary>
    [JsonPropertyName("baseFontHandle")]
    public string? baseFontHandle { get; set; } = null;

    /// <summary>
    /// The Shopify bold font handle.
    /// </summary>
    [JsonPropertyName("boldFontHandle")]
    public string? boldFontHandle { get; set; } = null;

    /// <summary>
    /// The font loading strategy.
    /// </summary>
    [JsonPropertyName("loadingStrategy")]
    public CheckoutAndAccountsConfigurationBrandingFontLoadingStrategy? loadingStrategy { get; set; } = null;
}