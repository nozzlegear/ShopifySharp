#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A list of individual customers eligible for the discount.
/// </summary>
public record DiscountCustomers : DiscountCustomerSelection, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The list of individual customers eligible for the discount.
    /// </summary>
    [JsonPropertyName("customers")]
    public ICollection<Customer>? customers { get; set; } = null;
}