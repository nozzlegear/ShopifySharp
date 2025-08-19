#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `urlRedirectCreate` mutation.
/// </summary>
public record UrlRedirectCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created redirect.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public UrlRedirect? urlRedirect { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UrlRedirectUserError>? userErrors { get; set; } = null;
}