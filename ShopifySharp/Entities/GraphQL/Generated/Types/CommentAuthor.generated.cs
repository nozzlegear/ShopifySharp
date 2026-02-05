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
/// The author of a comment on a blog article, containing the commenter's name and
/// email address. This information helps merchants moderate comments and
/// potentially engage with their community.
/// For example, when reviewing pending comments, merchants can see the commenter's
/// name and email to help with moderation decisions or to enable follow-up
/// communication if needed.
/// Use the `CommentAuthor` object to:
/// - Display comment attribution
/// - Support comment moderation workflows
/// - Enable merchant-to-reader communication
/// </summary>
public record CommentAuthor : IGraphQLObject
{
    /// <summary>
    /// The author's email.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The author’s name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}