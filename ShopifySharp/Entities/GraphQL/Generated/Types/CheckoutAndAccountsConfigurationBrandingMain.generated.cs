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
public record CheckoutAndAccountsConfigurationBrandingMain : IGraphQLObject
{
    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColors? colors { get; set; } = null;

    /// <summary>
    /// The main container's divider style and visibility.
    /// </summary>
    [JsonPropertyName("divider")]
    public CheckoutAndAccountsConfigurationBrandingContainerDivider? divider { get; set; } = null;

    /// <summary>
    /// The main sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutAndAccountsConfigurationBrandingMainSection? section { get; set; } = null;
}