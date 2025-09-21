#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A selection of customers for whom the price rule applies.
/// </summary>
public record PriceRuleCustomerSelection : IGraphQLObject
{
    /// <summary>
    /// List of customers to whom the price rule applies.
    /// </summary>
    [JsonPropertyName("customers")]
    public CustomerConnection? customers { get; set; } = null;

    /// <summary>
    /// Whether the price rule applies to all customers.
    /// </summary>
    [JsonPropertyName("forAllCustomers")]
    public bool? forAllCustomers { get; set; } = null;

    /// <summary>
    /// A list of customer segments that contain the customers who can use the price rule.
    /// </summary>
    [JsonPropertyName("segments")]
    public ICollection<Segment>? segments { get; set; } = null;
}