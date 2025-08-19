#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `draftOrderBulkRemoveTags` mutation.
/// </summary>
public record DraftOrderBulkRemoveTagsPayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job for removing tags from the draft orders.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}