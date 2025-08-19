#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to delete a customer.
/// </summary>
public record CustomerDeleteInput : GraphQLInputObject<CustomerDeleteInput>
{
    /// <summary>
    /// The ID of the customer to delete.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}