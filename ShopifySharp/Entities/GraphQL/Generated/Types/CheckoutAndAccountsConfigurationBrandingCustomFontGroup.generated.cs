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
/// The custom font group customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCustomFontGroup : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The base custom font.
    /// </summary>
    [JsonPropertyName("base")]
    public CheckoutAndAccountsConfigurationBrandingCustomFont? @base { get; set; } = null;

    /// <summary>
    /// The bold custom font.
    /// </summary>
    [JsonPropertyName("bold")]
    public CheckoutAndAccountsConfigurationBrandingCustomFont? bold { get; set; } = null;

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