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
public record CheckoutAndAccountsConfigurationBrandingHeader : IGraphQLObject
{
    /// <summary>
    /// The header alignment.
    /// </summary>
    [JsonPropertyName("alignment")]
    public CheckoutAndAccountsConfigurationBrandingHeaderAlignment? alignment { get; set; } = null;

    /// <summary>
    /// The background style of the header container.
    /// </summary>
    [JsonPropertyName("background")]
    public CheckoutAndAccountsConfigurationBrandingBackground? background { get; set; } = null;

    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColors? colors { get; set; } = null;

    /// <summary>
    /// The divided setting.
    /// </summary>
    [JsonPropertyName("divided")]
    public bool? divided { get; set; } = null;

    /// <summary>
    /// The store logo.
    /// </summary>
    [JsonPropertyName("logo")]
    public CheckoutAndAccountsConfigurationBrandingLogo? logo { get; set; } = null;

    /// <summary>
    /// The padding of the header container.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutAndAccountsConfigurationBrandingSpacingKeyword? padding { get; set; } = null;
}