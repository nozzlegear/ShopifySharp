#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to use to update the Express Checkout customizations.
/// </summary>
public record CheckoutBrandingExpressCheckoutInput : GraphQLInputObject<CheckoutBrandingExpressCheckoutInput>
{
    /// <summary>
    /// The Express Checkout buttons customizations.
    /// </summary>
    [JsonPropertyName("button")]
    public CheckoutBrandingExpressCheckoutButtonInput? button { get; set; } = null;
}