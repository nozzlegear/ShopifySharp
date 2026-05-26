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
/// The input fields for customizing the Express Checkout.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingExpressCheckoutInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingExpressCheckoutInput>
{
    /// <summary>
    /// The Express Checkout buttons customizations.
    /// </summary>
    [JsonPropertyName("button")]
    public CheckoutAndAccountsConfigurationBrandingExpressCheckoutButtonInput? button { get; set; } = null;
}