#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `articleDelete` mutation.
/// </summary>
public record ArticleDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted article.
    /// </summary>
    [JsonPropertyName("deletedArticleId")]
    public string? deletedArticleId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ArticleDeleteUserError>? userErrors { get; set; } = null;
}