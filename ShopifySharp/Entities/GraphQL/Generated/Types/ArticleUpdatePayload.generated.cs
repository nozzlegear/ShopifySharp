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
/// Return type for `articleUpdate` mutation.
/// </summary>
public record ArticleUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The article that was updated.
    /// </summary>
    [JsonPropertyName("article")]
    public Article? article { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ArticleUpdateUserError>? userErrors { get; set; } = null;
}