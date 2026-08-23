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
/// The sign-in-specific component customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSignInComponents : IGraphQLObject
{
    /// <summary>
    /// The header customizations.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutAndAccountsConfigurationBrandingSignInHeader? header { get; set; } = null;

    /// <summary>
    /// The main customizations.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutAndAccountsConfigurationBrandingSignInMain? main { get; set; } = null;
}