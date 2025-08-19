#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `commentApprove` mutation.
/// </summary>
public record CommentApprovePayload : IGraphQLObject
{
    /// <summary>
    /// The comment that was approved.
    /// </summary>
    [JsonPropertyName("comment")]
    public Comment? comment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CommentApproveUserError>? userErrors { get; set; } = null;
}