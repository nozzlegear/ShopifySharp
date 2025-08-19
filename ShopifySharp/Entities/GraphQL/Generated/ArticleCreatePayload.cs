#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `articleCreate` mutation.
/// </summary>
public record ArticleCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The article that was created.
    /// </summary>
    [JsonPropertyName("article")]
    public Article? article { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ArticleCreateUserError>? userErrors { get; set; } = null;
}