#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `urlRedirectUpdate` mutation.
/// </summary>
public record UrlRedirectUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// Returns the updated URL redirect.
    /// </summary>
    [JsonPropertyName("urlRedirect")]
    public UrlRedirect? urlRedirect { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UrlRedirectUserError>? userErrors { get; set; } = null;
}