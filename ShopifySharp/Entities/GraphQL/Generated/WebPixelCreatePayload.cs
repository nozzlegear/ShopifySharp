#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `webPixelCreate` mutation.
/// </summary>
public record WebPixelCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ErrorsWebPixelUserError>? userErrors { get; set; } = null;

    /// <summary>
    /// The created web pixel settings.
    /// </summary>
    [JsonPropertyName("webPixel")]
    public WebPixel? webPixel { get; set; } = null;
}