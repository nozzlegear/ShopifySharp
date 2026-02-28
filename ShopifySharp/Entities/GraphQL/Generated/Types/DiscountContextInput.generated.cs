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
/// The input fields for the buyers who can use this discount.
/// </summary>
public record DiscountContextInput : GraphQLInputObject<DiscountContextInput>
{
    /// <summary>
    /// All buyers are eligible for this discount.
    /// </summary>
    [JsonPropertyName("all")]
    public DiscountBuyerSelection? all { get; set; } = null;

    /// <summary>
    /// The list of customer IDs to add or remove from the list of customers.
    /// </summary>
    [JsonPropertyName("customers")]
    public DiscountCustomersInput? customers { get; set; } = null;

    /// <summary>
    /// The list of customer segment IDs to add or remove from the list of customer segments.
    /// </summary>
    [JsonPropertyName("customerSegments")]
    public DiscountCustomerSegmentsInput? customerSegments { get; set; } = null;
}