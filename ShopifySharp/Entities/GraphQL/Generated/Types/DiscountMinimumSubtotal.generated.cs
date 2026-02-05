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
/// The minimum subtotal required for the discount to apply.
/// </summary>
public record DiscountMinimumSubtotal : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The minimum subtotal that's required for the discount to be applied.
    /// </summary>
    [JsonPropertyName("greaterThanOrEqualToSubtotal")]
    public MoneyV2? greaterThanOrEqualToSubtotal { get; set; } = null;
}