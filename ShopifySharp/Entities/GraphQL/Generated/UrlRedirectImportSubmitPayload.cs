#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `urlRedirectImportSubmit` mutation.
/// </summary>
public record UrlRedirectImportSubmitPayload : IGraphQLObject
{
    /// <summary>
    /// The asynchronous job importing the redirects.
    /// </summary>
    [JsonPropertyName("job")]
    public Job? job { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UrlRedirectImportUserError>? userErrors { get; set; } = null;
}