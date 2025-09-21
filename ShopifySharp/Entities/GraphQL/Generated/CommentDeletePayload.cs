#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `commentDelete` mutation.
/// </summary>
public record CommentDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the comment that was deleted.
    /// </summary>
    [JsonPropertyName("deletedCommentId")]
    public string? deletedCommentId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CommentDeleteUserError>? userErrors { get; set; } = null;
}