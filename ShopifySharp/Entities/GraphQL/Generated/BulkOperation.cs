#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An asynchronous long-running operation to fetch data in bulk or to bulk import data.
/// Bulk operations are created using the `bulkOperationRunQuery` or `bulkOperationRunMutation` mutation. After
/// they are created, clients should poll the `status` field for updates. When `COMPLETED`, the `url` field contains
/// a link to the data in [JSONL](http://jsonlines.org/) format.
/// Refer to the [bulk operations guide](https://shopify.dev/api/usage/bulk-operations/imports) for more details.
/// </summary>
public record BulkOperation : IGraphQLObject, INode
{
    /// <summary>
    /// When the bulk operation was successfully completed.
    /// </summary>
    [JsonPropertyName("completedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? completedAt { get; set; } = null;

    /// <summary>
    /// When the bulk operation was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// Error code for failed operations.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public BulkOperationErrorCode? errorCode { get; set; } = null;

    /// <summary>
    /// File size in bytes of the file in the `url` field.
    /// </summary>
    [JsonPropertyName("fileSize")]
    public ulong? fileSize { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A running count of all the objects processed.
    /// For example, when fetching all the products and their variants, this field counts both products and variants.
    /// This field can be used to track operation progress.
    /// </summary>
    [JsonPropertyName("objectCount")]
    public ulong? objectCount { get; set; } = null;

    /// <summary>
    /// The URL that points to the partial or incomplete response data (in
    /// [JSONL](http://jsonlines.org/) format) that was returned by a failed operation.
    /// The URL expires 7 days after the operation fails. Returns `null` when there's no data available.
    /// </summary>
    [JsonPropertyName("partialDataUrl")]
    public string? partialDataUrl { get; set; } = null;

    /// <summary>
    /// GraphQL query document specified in `bulkOperationRunQuery`.
    /// </summary>
    [JsonPropertyName("query")]
    public string? query { get; set; } = null;

    /// <summary>
    /// A running count of all the objects that are processed at the root of the query.
    /// For example, when fetching all the products and their variants, this field only counts products.
    /// This field can be used to track operation progress.
    /// </summary>
    [JsonPropertyName("rootObjectCount")]
    public ulong? rootObjectCount { get; set; } = null;

    /// <summary>
    /// Status of the bulk operation.
    /// </summary>
    [JsonPropertyName("status")]
    public BulkOperationStatus? status { get; set; } = null;

    /// <summary>
    /// The bulk operation's type.
    /// </summary>
    [JsonPropertyName("type")]
    public BulkOperationType? type { get; set; } = null;

    /// <summary>
    /// The URL that points to the response data in [JSONL](http://jsonlines.org/) format.
    /// The URL expires 7 days after the operation completes.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}