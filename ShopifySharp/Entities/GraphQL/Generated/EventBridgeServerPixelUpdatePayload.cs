#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `eventBridgeServerPixelUpdate` mutation.
/// </summary>
public record EventBridgeServerPixelUpdatePayload : IGraphQLObject
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