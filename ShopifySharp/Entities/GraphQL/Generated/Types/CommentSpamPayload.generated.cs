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
/// Return type for `commentSpam` mutation.
/// </summary>
public record CommentSpamPayload : IGraphQLObject
{
    /// <summary>
    /// The comment that was marked as spam.
    /// </summary>
    [JsonPropertyName("comment")]
    public Comment? comment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CommentSpamUserError>? userErrors { get; set; } = null;
}