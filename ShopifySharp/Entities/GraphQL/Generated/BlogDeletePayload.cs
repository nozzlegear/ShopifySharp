#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `blogDelete` mutation.
/// </summary>
public record BlogDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted blog.
    /// </summary>
    [JsonPropertyName("deletedBlogId")]
    public string? deletedBlogId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BlogDeleteUserError>? userErrors { get; set; } = null;
}