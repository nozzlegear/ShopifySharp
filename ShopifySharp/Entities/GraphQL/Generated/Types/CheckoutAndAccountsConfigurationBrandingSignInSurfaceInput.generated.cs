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
/// The input fields for customizing the sign-in surface.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSignInSurfaceInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingSignInSurfaceInput>
{
    /// <summary>
    /// The sign-in components.
    /// </summary>
    [JsonPropertyName("components")]
    public CheckoutAndAccountsConfigurationBrandingSignInComponentsInput? components { get; set; } = null;
}