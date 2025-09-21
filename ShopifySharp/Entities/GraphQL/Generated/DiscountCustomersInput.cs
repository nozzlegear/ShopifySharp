#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for which customers to add to or remove from the discount.
/// </summary>
public record DiscountCustomersInput : GraphQLInputObject<DiscountCustomersInput>
{
    /// <summary>
    /// A list of customers to add to the current list of customers who can use the discount.
    /// </summary>
    [JsonPropertyName("add")]
    public ICollection<string>? @add { get; set; } = null;

    /// <summary>
    /// A list of customers to remove from the current list of customers who can use the discount.
    /// </summary>
    [JsonPropertyName("remove")]
    public ICollection<string>? @remove { get; set; } = null;
}