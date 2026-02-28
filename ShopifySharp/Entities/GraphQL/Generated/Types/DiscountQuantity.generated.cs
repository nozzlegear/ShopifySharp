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
/// Defines a quantity threshold for discount eligibility or application. This
/// simple object specifies the number of items required to trigger or calculate
/// discount benefits.
/// For example, a "Buy 3, Get 1 Free" promotion would use DiscountQuantity to
/// define the minimum purchase quantity of 3 items, or a bulk discount might
/// specify quantity tiers like 10+ items for wholesale pricing.
/// The quantity value determines how discounts interact with cart contents, whether
/// setting minimum purchase requirements or defining quantity-based discount calculations.
/// </summary>
public record DiscountQuantity : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The quantity of items.
    /// </summary>
    [JsonPropertyName("quantity")]
    public ulong? quantity { get; set; } = null;
}