#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `webPixelDelete` mutation.
/// </summary>
public record WebPixelDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the web pixel settings that was deleted.
    /// </summary>
    [JsonPropertyName("deletedWebPixelId")]
    public string? deletedWebPixelId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ErrorsWebPixelUserError>? userErrors { get; set; } = null;
}