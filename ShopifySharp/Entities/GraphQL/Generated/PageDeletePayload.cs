#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `pageDelete` mutation.
/// </summary>
public record PageDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted page.
    /// </summary>
    [JsonPropertyName("deletedPageId")]
    public string? deletedPageId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PageDeleteUserError>? userErrors { get; set; } = null;
}