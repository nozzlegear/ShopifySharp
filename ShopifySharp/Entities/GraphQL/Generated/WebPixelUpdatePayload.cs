#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `webPixelUpdate` mutation.
/// </summary>
public record WebPixelUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ErrorsWebPixelUserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The updated web pixel settings.
    /// </summary>
    [JsonPropertyName("webPixel")]
    public WebPixel? webPixel { get; set; } = null;
}