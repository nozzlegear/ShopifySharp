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
/// A container for the customer accounts footer section customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooter : IGraphQLObject
{
    /// <summary>
    /// The footer alignment.
    /// </summary>
    [JsonPropertyName("alignment")]
    public CheckoutAndAccountsConfigurationBrandingFooterAlignment? alignment { get; set; } = null;

    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColors? colors { get; set; } = null;

    /// <summary>
    /// The padding of the footer container.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutAndAccountsConfigurationBrandingSpacingKeyword? padding { get; set; } = null;
}