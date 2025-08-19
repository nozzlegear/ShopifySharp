#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `tagsRemove` mutation.
/// </summary>
public record TagsRemovePayload : IGraphQLObject
{
    /// <summary>
    /// The object that was updated.
    /// </summary>
    [JsonPropertyName("node")]
    public INode? node { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}