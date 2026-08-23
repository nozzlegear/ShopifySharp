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
/// Per-row metadata for a ShopifyQL result, aligned by index with the table's rows.
/// </summary>
public record ShopifyqlRowMetadata : IGraphQLObject
{
    /// <summary>
    /// Localized display text for null cells in this row, by column.
    /// </summary>
    [JsonPropertyName("nullCellTranslations")]
    public ICollection<ShopifyqlNullCellTranslation>? nullCellTranslations { get; set; } = null;

    /// <summary>
    /// Raw resource IDs associated with the row, aligned by column index. Each entry
    /// is the list of IDs for that column (empty when the cell has none). These are
    /// raw ShopifyQL identifiers (numeric IDs, or image URLs for some schemas), not GIDs.
    /// </summary>
    [JsonPropertyName("rawResourceIds")]
    public ICollection<ICollection<string>>? rawResourceIds { get; set; } = null;

    /// <summary>
    /// Names of the columns whose values were rolled into the top-N "Other" remainder bucket.
    /// </summary>
    [JsonPropertyName("topNRemainderColumnNames")]
    public ICollection<string>? topNRemainderColumnNames { get; set; } = null;
}