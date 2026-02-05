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