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
/// The sign-in-specific main customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSignInMain : IGraphQLObject
{
    /// <summary>
    /// The background image of the main container.
    /// </summary>
    [JsonPropertyName("backgroundImage")]
    public CheckoutAndAccountsConfigurationBrandingImageValue? backgroundImage { get; set; } = null;

    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColors? colors { get; set; } = null;

    /// <summary>
    /// The main sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutAndAccountsConfigurationBrandingMainSection? section { get; set; } = null;
}