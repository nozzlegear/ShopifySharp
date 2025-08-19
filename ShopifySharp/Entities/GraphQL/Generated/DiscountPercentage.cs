#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A discount effect that gives customers a percentage off of specified items on their order.
/// </summary>
public record DiscountPercentage : DiscountCustomerGetsValue, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The percentage value of the discount.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}