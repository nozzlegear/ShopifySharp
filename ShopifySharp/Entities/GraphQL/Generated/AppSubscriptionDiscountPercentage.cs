#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The percentage value of a discount.
/// </summary>
public record AppSubscriptionDiscountPercentage : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The percentage value of a discount.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}