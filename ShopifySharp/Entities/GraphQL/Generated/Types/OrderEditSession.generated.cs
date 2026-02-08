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
/// An edit session for an order.
/// </summary>
public record OrderEditSession : IGraphQLObject, INode
{
    /// <summary>
    /// The unique ID of the order edit session.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}