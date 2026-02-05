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
/// An asynchronous operation that exports large datasets or imports data in bulk.
/// Create bulk operations using [bulkOperationRunQuery](https://shopify.dev/docs/api/admin-graphql/latest/mutations/bulkOperationRunQuery)
/// to export data or [bulkOperationRunMutation](https://shopify.dev/docs/api/admin-graphql/latest/mutations/bulkOperationRunMutation)
/// to import data.
/// After creation, check the [`status`](https://shopify.dev/docs/api/admin-graphql/latest/objects/BulkOperation#field-BulkOperation.fields.status)
/// field to track progress. When completed, the [`url`](https://shopify.dev/docs/api/admin-graphql/latest/objects/BulkOperation#field-BulkOperation.fields.url)
/// field contains a link to download results in [JSONL](http://jsonlines.org/) format. The [`objectCount`](https://shopify.dev/docs/api/admin-graphql/latest/objects/BulkOperation#field-BulkOperation.fields.objectCount)
/// field shows the running total of processed objects, while [`rootObjectCount`](https://shopify.dev/docs/api/admin-graphql/latest/objects/BulkOperation#field-BulkOperation.fields.rootObjectCount)
/// tracks only root-level objects in nested queries.
/// If an operation fails but retrieves partial data, then the [`partialDataUrl`](https://shopify.dev/docs/api/admin-graphql/latest/objects/BulkOperation#field-BulkOperation.fields.partialDataUrl)
/// field provides access to incomplete results.
/// > Note: `url` and `partialDataUrl` values expire after seven days.
/// Learn more about
/// [exporting](https://shopify.dev/docs/api/usage/bulk-operations/queries) and
/// [importing](https://shopify.dev/docs/api/usage/bulk-operations/imports) data in bulk.
/// </summary>
public record BulkOperation : IGraphQLObject, INode
{
    /// <summary>
    /// When the bulk operation was successfully completed.
    /// </summary>
    [JsonPropertyName("completedAt")]
    public DateTimeOffset? completedAt { get; set; } = null;

    /// <summary>
    /// When the bulk operation was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

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