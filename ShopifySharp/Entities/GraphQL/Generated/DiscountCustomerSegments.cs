#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A list of customer segments who are eligible for the discount.
/// </summary>
public record DiscountCustomerSegments : DiscountCustomerSelection, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The list of customer segments who are eligible for the discount.
    /// </summary>
    [JsonPropertyName("segments")]
    public ICollection<Segment>? segments { get; set; } = null;
}