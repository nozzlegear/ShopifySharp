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
/// The input fields for customizing the customer accounts header.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderInput>
{
    /// <summary>
    /// The header alignment.
    /// </summary>
    [JsonPropertyName("alignment")]
    public CheckoutAndAccountsConfigurationBrandingHeaderAlignment? alignment { get; set; } = null;

    /// <summary>
    /// The colors customizations for the header container.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColorsInput? colors { get; set; } = null;

    /// <summary>
    /// The store logo.
    /// </summary>
    [JsonPropertyName("logo")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsLogoInput? logo { get; set; } = null;

    /// <summary>
    /// The padding of the header container.
    /// </summary>
    [JsonPropertyName("padding")]
    public CheckoutAndAccountsConfigurationBrandingSpacingKeyword? padding { get; set; } = null;
}