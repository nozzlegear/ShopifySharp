#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The customizations that you can make to cart links at checkout.
/// </summary>
public record CheckoutBrandingCartLink : IGraphQLObject
{
    /// <summary>
    /// Whether the cart link is visible at checkout.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}