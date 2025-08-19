#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `pageUpdate` mutation.
/// </summary>
public record PageUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The page that was updated.
    /// </summary>
    [JsonPropertyName("page")]
    public Page? page { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PageUpdateUserError>? userErrors { get; set; } = null;
}