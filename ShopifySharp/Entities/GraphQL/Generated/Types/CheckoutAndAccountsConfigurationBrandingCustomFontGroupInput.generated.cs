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
/// The input fields for customizing a custom font group.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCustomFontGroupInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingCustomFontGroupInput>
{
    /// <summary>
    /// The base font.
    /// </summary>
    [JsonPropertyName("base")]
    public CheckoutAndAccountsConfigurationBrandingCustomFontInput? @base { get; set; } = null;

    /// <summary>
    /// The bold font.
    /// </summary>
    [JsonPropertyName("bold")]
    public CheckoutAndAccountsConfigurationBrandingCustomFontInput? bold { get; set; } = null;

    /// <summary>
    /// The font loading strategy.
    /// </summary>
    [JsonPropertyName("loadingStrategy")]
    public CheckoutAndAccountsConfigurationBrandingFontLoadingStrategy? loadingStrategy { get; set; } = null;
}