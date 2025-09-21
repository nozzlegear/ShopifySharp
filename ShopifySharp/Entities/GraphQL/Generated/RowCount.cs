#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A row count represents rows on background operation.
/// </summary>
public record RowCount : IGraphQLObject
{
    /// <summary>
    /// Estimated number of rows contained within this background operation.
    /// </summary>
    [JsonPropertyName("count")]
    public int? count { get; set; } = null;

    /// <summary>
    /// Whether the operation exceeds max number of reportable rows.
    /// </summary>
    [JsonPropertyName("exceedsMax")]
    public bool? exceedsMax { get; set; } = null;
}