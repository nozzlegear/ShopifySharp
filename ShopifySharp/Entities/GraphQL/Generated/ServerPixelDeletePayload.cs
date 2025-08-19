#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `serverPixelDelete` mutation.
/// </summary>
public record ServerPixelDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the server pixel that was deleted, if one was deleted.
    /// </summary>
    [JsonPropertyName("deletedServerPixelId")]
    public string? deletedServerPixelId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ErrorsServerPixelUserError>? userErrors { get; set; } = null;
}