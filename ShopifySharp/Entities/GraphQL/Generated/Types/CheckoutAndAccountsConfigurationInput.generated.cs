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
/// The input fields for checkout and account configurations.
/// </summary>
public record CheckoutAndAccountsConfigurationInput : GraphQLInputObject<CheckoutAndAccountsConfigurationInput>
{
    /// <summary>
    /// The branding settings of the configuration.
    /// </summary>
    [JsonPropertyName("branding")]
    public CheckoutAndAccountsConfigurationBrandingInput? branding { get; set; } = null;

    /// <summary>
    /// The overrides to create/update in the configuration.
    /// </summary>
    [JsonPropertyName("overrides")]
    public ICollection<CheckoutAndAccountsConfigurationOverrideInput>? overrides { get; set; } = null;
}