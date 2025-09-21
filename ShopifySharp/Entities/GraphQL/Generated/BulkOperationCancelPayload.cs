#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `bulkOperationCancel` mutation.
/// </summary>
public record BulkOperationCancelPayload : IGraphQLObject
{
    /// <summary>
    /// The bulk operation to be canceled.
    /// </summary>
    [JsonPropertyName("bulkOperation")]
    public BulkOperation? bulkOperation { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}