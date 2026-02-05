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
/// The Express Checkout button customizations.
/// </summary>
public record CheckoutBrandingExpressCheckoutButton : IGraphQLObject
{
    /// <summary>
    /// The corner radius used for the Express Checkout buttons.
    /// </summary>
    [JsonPropertyName("cornerRadius")]
    public CheckoutBrandingCornerRadius? cornerRadius { get; set; } = null;
}