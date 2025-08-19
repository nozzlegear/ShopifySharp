#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The Express Checkout customizations.
/// </summary>
public record CheckoutBrandingExpressCheckout : IGraphQLObject
{
    /// <summary>
    /// The Express Checkout buttons customizations.
    /// </summary>
    [JsonPropertyName("button")]
    public CheckoutBrandingExpressCheckoutButton? button { get; set; } = null;
}