#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an operation publishing all products to a publication.
/// </summary>
public record AddAllProductsOperation : PublicationOperation, IGraphQLUnionCase, IGraphQLObject, INode, IResourceOperation
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The count of processed rows, summing imported, failed, and skipped rows.
    /// </summary>
    [JsonPropertyName("processedRowCount")]
    public int? processedRowCount { get; set; } = null;

    /// <summary>
    /// Represents a rows objects within this background operation.
    /// </summary>
    [JsonPropertyName("rowCount")]
    public RowCount? rowCount { get; set; } = null;

    /// <summary>
    /// The status of this operation.
    /// </summary>
    [JsonPropertyName("status")]
    public ResourceOperationStatus? status { get; set; } = null;
}