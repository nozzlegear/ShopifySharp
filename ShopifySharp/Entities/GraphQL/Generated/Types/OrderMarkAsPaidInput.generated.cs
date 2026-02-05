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
/// The input fields for specifying the order to mark as paid.
/// </summary>
public record OrderMarkAsPaidInput : GraphQLInputObject<OrderMarkAsPaidInput>
{
    /// <summary>
    /// The ID of the order to mark as paid.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}