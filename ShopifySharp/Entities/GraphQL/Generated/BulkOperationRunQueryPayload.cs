#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `bulkOperationRunQuery` mutation.
/// </summary>
public record BulkOperationRunQueryPayload : IGraphQLObject
{
    /// <summary>
    /// The newly created bulk operation.
    /// </summary>
    [JsonPropertyName("bulkOperation")]
    public BulkOperation? bulkOperation { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BulkOperationUserError>? userErrors { get; set; } = null;
}