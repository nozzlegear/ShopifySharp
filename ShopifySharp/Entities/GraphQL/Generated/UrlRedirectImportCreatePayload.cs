#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `urlRedirectImportCreate` mutation.
/// </summary>
public record UrlRedirectImportCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created `URLRedirectImport` object.
    /// </summary>
    [JsonPropertyName("urlRedirectImport")]
    public UrlRedirectImport? urlRedirectImport { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UrlRedirectImportUserError>? userErrors { get; set; } = null;
}