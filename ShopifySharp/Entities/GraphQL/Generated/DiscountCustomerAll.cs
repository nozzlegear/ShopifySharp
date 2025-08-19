#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The `DiscountCustomerAll` object lets you target all customers for discount eligibility.
/// </summary>
public record DiscountCustomerAll : DiscountCustomerSelection, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Whether the discount can be applied by all customers. This value is always `true`.
    /// </summary>
    [JsonPropertyName("allCustomers")]
    public bool? allCustomers { get; set; } = null;
}