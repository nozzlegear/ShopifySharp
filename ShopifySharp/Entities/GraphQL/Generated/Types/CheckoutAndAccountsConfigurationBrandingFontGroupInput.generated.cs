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
/// The input fields used to update a font group.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingFontGroupInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingFontGroupInput>
{
    /// <summary>
    /// A custom font group.
    /// </summary>
    [JsonPropertyName("customFontGroup")]
    public CheckoutAndAccountsConfigurationBrandingCustomFontGroupInput? customFontGroup { get; set; } = null;

    /// <summary>
    /// A Shopify font group.
    /// </summary>
    [JsonPropertyName("shopifyFontGroup")]
    public CheckoutAndAccountsConfigurationBrandingShopifyFontGroupInput? shopifyFontGroup { get; set; } = null;
}