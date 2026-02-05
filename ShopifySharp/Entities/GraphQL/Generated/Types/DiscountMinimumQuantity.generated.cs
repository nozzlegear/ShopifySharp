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
/// Specifies the minimum item quantity required for discount eligibility, helping
/// merchants create volume-based promotions that encourage larger purchases. This
/// threshold applies to qualifying items in the customer's cart.
/// For example, a "Buy 3, Get 10% Off" promotion would set the minimum quantity to 3 items.
/// Learn more about [discount requirements](https://shopify.dev/docs/api/admin-graphql/latest/objects/DiscountApplication).
/// </summary>
public record DiscountMinimumQuantity : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The minimum quantity of items that's required for the discount to be applied.
    /// </summary>
    [JsonPropertyName("greaterThanOrEqualToQuantity")]
    public ulong? greaterThanOrEqualToQuantity { get; set; } = null;
}