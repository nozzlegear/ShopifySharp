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
/// The input fields for checkout and account configuration overrides.
/// </summary>
public record CheckoutAndAccountsConfigurationOverrideInput : GraphQLInputObject<CheckoutAndAccountsConfigurationOverrideInput>
{
    /// <summary>
    /// The branding settings of the configuration.
    /// </summary>
    [JsonPropertyName("branding")]
    public CheckoutAndAccountsConfigurationBrandingInput? branding { get; set; } = null;

    /// <summary>
    /// The ID of the configuration override to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}