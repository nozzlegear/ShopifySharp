#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to use to update the express checkout customizations.
/// </summary>
public record CheckoutBrandingExpressCheckoutButtonInput : GraphQLInputObject<CheckoutBrandingExpressCheckoutButtonInput>
{
    /// <summary>
    /// The corner radius used for Express Checkout buttons.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;
}