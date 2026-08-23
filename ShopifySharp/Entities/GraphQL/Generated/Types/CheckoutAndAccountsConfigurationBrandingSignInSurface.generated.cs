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
public record CheckoutAndAccountsConfigurationBrandingSignInSurface : IGraphQLObject
{
    /// <summary>
    /// The sign-in components.
    /// </summary>
    [JsonPropertyName("components")]
    public CheckoutAndAccountsConfigurationBrandingSignInComponents? components { get; set; } = null;
}