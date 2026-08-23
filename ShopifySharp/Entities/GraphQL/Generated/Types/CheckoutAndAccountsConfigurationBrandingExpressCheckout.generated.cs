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
/// The Express Checkout customizations.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingExpressCheckout : IGraphQLObject
{
    /// <summary>
    /// The Express Checkout buttons customizations.
    /// </summary>
    [JsonPropertyName("button")]
    public CheckoutAndAccountsConfigurationBrandingExpressCheckoutButton? button { get; set; } = null;
}