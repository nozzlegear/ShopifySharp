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
/// The input fields for customizing surfaces branding.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSurfacesInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingSurfacesInput>
{
    /// <summary>
    /// The checkout surface customizations.
    /// </summary>
    [JsonPropertyName("checkout")]
    public CheckoutAndAccountsConfigurationBrandingCheckoutSurfaceInput? checkout { get; set; } = null;

    /// <summary>
    /// The customer accounts surface customizations.
    /// </summary>
    [JsonPropertyName("customerAccounts")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsSurfaceInput? customerAccounts { get; set; } = null;

    /// <summary>
    /// The sign-in surface customizations.
    /// </summary>
    [JsonPropertyName("signIn")]
    public CheckoutAndAccountsConfigurationBrandingSignInSurfaceInput? signIn { get; set; } = null;
}