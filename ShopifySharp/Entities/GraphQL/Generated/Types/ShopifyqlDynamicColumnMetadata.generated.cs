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
/// Describes how a dynamically generated column relates to the query.
/// </summary>
public record ShopifyqlDynamicColumnMetadata : IGraphQLObject
{
    /// <summary>
    /// The names of the dimension columns this column is aggregated (grouped) by.
    /// </summary>
    [JsonPropertyName("aggregatedBy")]
    public ICollection<string>? aggregatedBy { get; set; } = null;

    /// <summary>
    /// What the column is compared against. For benchmark columns, the percentile
    /// (e.g. `p50`); for comparison columns, the comparison period or date offset.
    /// Interpret based on `type`.
    /// </summary>
    [JsonPropertyName("comparisonReference")]
    public string? comparisonReference { get; set; } = null;

    /// <summary>
    /// The query column this dynamic column was derived from (e.g. `total_sales`).
    /// </summary>
    [JsonPropertyName("originalColumnName")]
    public string? originalColumnName { get; set; } = null;

    /// <summary>
    /// The kind of dynamic column.
    /// </summary>
    [JsonPropertyName("type")]
    public ShopifyqlDynamicColumnType? type { get; set; } = null;
}