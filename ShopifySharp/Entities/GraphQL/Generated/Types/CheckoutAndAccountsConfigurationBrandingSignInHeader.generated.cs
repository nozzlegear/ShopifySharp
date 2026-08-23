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
/// The sign-in header customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSignInHeader : IGraphQLObject
{
    /// <summary>
    /// The store logo.
    /// </summary>
    [JsonPropertyName("logo")]
    public CheckoutAndAccountsConfigurationBrandingSignInLogo? logo { get; set; } = null;

    /// <summary>
    /// The padding of the header container.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutAndAccountsConfigurationBrandingSpacingKeyword? padding { get; set; } = null;
}