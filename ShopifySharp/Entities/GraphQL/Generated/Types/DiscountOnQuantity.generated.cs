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
/// Defines quantity-based discount rules that specify how many items are eligible
/// for a discount effect. This object enables bulk purchase incentives and tiered
/// pricing strategies.
/// For example, a "Buy 4 candles, get 2 candles 50% off (mix and match)" promotion
/// would specify a quantity threshold of 2 items that will receive a percentage
/// discount effect, encouraging customers to purchase more items to unlock savings.
/// The configuration combines quantity requirements with discount effects, allowing
/// merchants to create sophisticated pricing rules that reward larger purchases and
/// increase average order values.
/// </summary>
public record DiscountOnQuantity : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The discount's effect on qualifying items.
    /// </summary>
    [JsonPropertyName("effect")]
    public DiscountEffect? effect { get; set; } = null;

    /// <summary>
    /// The number of items being discounted. The customer must have at least this
    /// many items of specified products or product variants in their order to be
    /// eligible for the discount.
    /// </summary>
    [JsonPropertyName("quantity")]
    public DiscountQuantity? quantity { get; set; } = null;
}