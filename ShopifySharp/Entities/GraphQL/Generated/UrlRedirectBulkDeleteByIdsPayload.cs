#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `urlRedirectBulkDeleteByIds` mutation.
/// </summary>
public record UrlRedirectBulkDeleteByIdsPayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job removing the redirects.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UrlRedirectBulkDeleteByIdsUserError>? userErrors { get; set; } = null;
}