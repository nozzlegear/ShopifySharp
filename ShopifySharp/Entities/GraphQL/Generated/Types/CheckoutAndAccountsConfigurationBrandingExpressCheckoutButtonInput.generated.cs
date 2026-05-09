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
/// The input fields for customizing the express checkout button.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonInput>
{
    /// <summary>
    /// The corner radius.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutAndAccountsConfigurationBrandingCornerRadius? cornerRadius { get; set; } = null;
}