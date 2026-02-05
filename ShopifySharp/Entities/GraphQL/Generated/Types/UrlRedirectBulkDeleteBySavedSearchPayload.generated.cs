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