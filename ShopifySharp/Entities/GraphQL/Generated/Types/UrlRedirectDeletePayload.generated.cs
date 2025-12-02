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
/// Return type for `urlRedirectDelete` mutation.
/// </summary>
public record UrlRedirectDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted redirect.
    /// </summary>
    [JsonPropertyName("deletedUrlRedirectId")]
    public string? deletedUrlRedirectId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UrlRedirectUserError>? userErrors { get; set; } = null;
}