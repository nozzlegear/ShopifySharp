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
/// The customer accounts-specific component customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponents : IGraphQLObject
{
    /// <summary>
    /// The footer customizations.
    /// </summary>
    [JsonPropertyName("footer")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooter? footer { get; set; } = null;

    /// <summary>
    /// The header customizations.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeader? header { get; set; } = null;

    /// <summary>
    /// The main customer accounts customizations.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMain? main { get; set; } = null;
}