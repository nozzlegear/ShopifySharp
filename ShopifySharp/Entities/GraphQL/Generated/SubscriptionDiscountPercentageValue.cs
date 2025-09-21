#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The percentage value of the discount.
/// </summary>
public record SubscriptionDiscountPercentageValue : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The percentage value of the discount.
    /// </summary>
    [JsonPropertyName("percentage")]
    public int? percentage { get; set; } = null;
}