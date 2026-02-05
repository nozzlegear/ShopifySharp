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
/// Represents a draft order tag.
/// </summary>
public record DraftOrderTag : IGraphQLObject, INode
{
    /// <summary>
    /// Handle of draft order tag.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// ID of draft order tag.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Title of draft order tag.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}