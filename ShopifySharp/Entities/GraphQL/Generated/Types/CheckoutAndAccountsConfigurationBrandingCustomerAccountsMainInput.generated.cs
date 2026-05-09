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
/// The input fields for customizing the main container.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainInput>
{
    /// <summary>
    /// The colors customizations.
    /// </summary>
    [JsonPropertyName("colors")]
    public CheckoutAndAccountsConfigurationBrandingColorsInput? colors { get; set; } = null;

    /// <summary>
    /// The customizations for the main sections.
    /// </summary>
    [JsonPropertyName("section")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainSectionInput? section { get; set; } = null;
}