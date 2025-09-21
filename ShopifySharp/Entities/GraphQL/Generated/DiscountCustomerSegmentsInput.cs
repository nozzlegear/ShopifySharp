#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for which customer segments to add to or remove from the discount.
/// </summary>
public record DiscountCustomerSegmentsInput : GraphQLInputObject<DiscountCustomerSegmentsInput>
{
    /// <summary>
    /// A list of customer segments to add to the current list of customer segments.
    /// </summary>
    [JsonPropertyName("add")]
    public ICollection<string>? @add { get; set; } = null;

    /// <summary>
    /// A list of customer segments to remove from the current list of customer segments.
    /// </summary>
    [JsonPropertyName("remove")]
    public ICollection<string>? @remove { get; set; } = null;
}