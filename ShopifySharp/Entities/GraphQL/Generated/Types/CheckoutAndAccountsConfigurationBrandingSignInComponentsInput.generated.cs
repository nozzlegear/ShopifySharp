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
/// The input fields for customizing the sign-in components.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingSignInComponentsInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingSignInComponentsInput>
{
    /// <summary>
    /// The header customizations.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutAndAccountsConfigurationBrandingSignInHeaderInput? header { get; set; } = null;

    /// <summary>
    /// The main customizations.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutAndAccountsConfigurationBrandingSignInMainInput? main { get; set; } = null;
}