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
/// The surface-specific component customizations for checkout and customer accounts.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSurfaces : IGraphQLObject
{
    /// <summary>
    /// The checkout-specific component overrides.
    /// </summary>
    [JsonPropertyName("checkout")]
    public CheckoutAndAccountsConfigurationBrandingCheckoutSurface? checkout { get; set; } = null;

    /// <summary>
    /// The customer accounts-specific component overrides.
    /// </summary>
    [JsonPropertyName("customerAccounts")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurface? customerAccounts { get; set; } = null;

    /// <summary>
    /// The sign-in-specific component overrides.
    /// </summary>
    [JsonPropertyName("signIn")]
    public CheckoutAndAccountsConfigurationBrandingSignInSurface? signIn { get; set; } = null;
}