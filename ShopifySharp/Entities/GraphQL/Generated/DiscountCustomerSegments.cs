#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A list of customer segments who are eligible for the discount.
/// </summary>
public record DiscountCustomerSegments : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The list of customer segments who are eligible for the discount.
    /// </summary>
    [JsonPropertyName("segments")]
    public ICollection<Segment>? segments { get; set; } = null;
}