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
/// Controls the visibility of cart links displayed during checkout. These links
/// allow customers to return to their cart or continue shopping.
/// For example, an electronics store might hide cart links during final checkout
/// steps to reduce distractions, or show them prominently to encourage customers to
/// add accessories before completing their purchase.
/// The `CartLink` object provides visibility settings to control when and how these
/// navigation elements appear based on the merchant's checkout flow strategy.
/// </summary>
public record CheckoutBrandingCartLink : IGraphQLObject
{
    /// <summary>
    /// Whether the cart link is visible at checkout.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}