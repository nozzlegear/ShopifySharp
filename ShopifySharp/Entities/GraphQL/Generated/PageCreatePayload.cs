#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `pageCreate` mutation.
/// </summary>
public record PageCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The page that was created.
    /// </summary>
    [JsonPropertyName("page")]
    public Page? page { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PageCreateUserError>? userErrors { get; set; } = null;
}