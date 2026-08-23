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
/// Represents a column in a ShopifyQL query response.
/// </summary>
public record ShopifyqlTableDataColumn : IGraphQLObject
{
    /// <summary>
    /// Whether the column was explicitly requested in the query or dynamically generated.
    /// </summary>
    [JsonPropertyName("columnOrigin")]
    public ShopifyqlColumnOrigin? columnOrigin { get; set; } = null;

    /// <summary>
    /// The data type of the column.
    /// </summary>
    [JsonPropertyName("dataType")]
    public ColumnDataType? dataType { get; set; } = null;

    /// <summary>
    /// The human-readable display name of the column.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// Metadata describing how a dynamic column was generated (comparison, totals,
    /// benchmark, attribution, etc.). Null for non-dynamic columns.
    /// </summary>
    [JsonPropertyName("dynamicColumnMetadata")]
    public ShopifyqlDynamicColumnMetadata? dynamicColumnMetadata { get; set; } = null;

    /// <summary>
    /// The name of the column.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A shortened display name for the column, suitable for compact UI such as metric tiles.
    /// </summary>
    [JsonPropertyName("shortDisplayName")]
    public string? shortDisplayName { get; set; } = null;

    /// <summary>
    /// The sub type of an array column.
    /// </summary>
    [JsonPropertyName("subType")]
    public ColumnDataType? subType { get; set; } = null;
}