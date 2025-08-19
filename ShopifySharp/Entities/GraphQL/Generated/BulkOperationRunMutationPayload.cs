#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `bulkOperationRunMutation` mutation.
/// </summary>
public record BulkOperationRunMutationPayload : IGraphQLObject
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
    public ICollection<BulkMutationUserError>? userErrors { get; set; } = null;
}