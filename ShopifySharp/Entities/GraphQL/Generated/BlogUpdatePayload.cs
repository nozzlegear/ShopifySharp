#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `blogUpdate` mutation.
/// </summary>
public record BlogUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The blog that was updated.
    /// </summary>
    [JsonPropertyName("blog")]
    public Blog? blog { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<BlogUpdateUserError>? userErrors { get; set; } = null;
}