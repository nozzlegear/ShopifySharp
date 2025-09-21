#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `pubSubServerPixelUpdate` mutation.
/// </summary>
public record PubSubServerPixelUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The server pixel as configured by the mutation.
    /// </summary>
    [JsonPropertyName("serverPixel")]
    public ServerPixel? serverPixel { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ErrorsServerPixelUserError>? userErrors { get; set; } = null;
}