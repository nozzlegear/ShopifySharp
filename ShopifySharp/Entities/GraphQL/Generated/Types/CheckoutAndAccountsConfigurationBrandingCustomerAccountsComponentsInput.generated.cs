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
/// The input fields for customizing the Customer Accounts components.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingCustomerAccountsComponentsInput>
{
    /// <summary>
    /// The footer customizations.
    /// </summary>
    [JsonPropertyName("footer")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsFooterInput? footer { get; set; } = null;

    /// <summary>
    /// The header customizations.
    /// </summary>
    [JsonPropertyName("header")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsHeaderInput? header { get; set; } = null;

    /// <summary>
    /// The main area customizations.
    /// </summary>
    [JsonPropertyName("main")]
    public CheckoutAndAccountsConfigurationBrandingCustomerAccountsMainInput? main { get; set; } = null;
}