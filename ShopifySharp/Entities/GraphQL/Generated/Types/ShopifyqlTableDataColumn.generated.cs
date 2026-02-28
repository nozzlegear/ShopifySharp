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
    /// The name of the column.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The sub type of an array column.
    /// </summary>
    [JsonPropertyName("subType")]
    public ColumnDataType? subType { get; set; } = null;
}