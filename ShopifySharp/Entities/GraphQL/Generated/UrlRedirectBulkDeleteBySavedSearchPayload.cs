#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `urlRedirectBulkDeleteBySavedSearch` mutation.
/// </summary>
public record UrlRedirectBulkDeleteBySavedSearchPayload : IGraphQLObject
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
    public ICollection<UrlRedirectBulkDeleteBySavedSearchUserError>? userErrors { get; set; } = null;
}