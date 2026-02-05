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
/// The input fields for specifying an open order to close.
/// </summary>
public record OrderCloseInput : GraphQLInputObject<OrderCloseInput>
{
    /// <summary>
    /// The ID of the order to close.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}