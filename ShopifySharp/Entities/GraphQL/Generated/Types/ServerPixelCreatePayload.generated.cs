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
/// Return type for `serverPixelCreate` mutation.
/// </summary>
public record ServerPixelCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The new server pixel.
    /// </summary>
    [JsonPropertyName("serverPixel")]
    public ServerPixel? serverPixel { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ErrorsServerPixelUserError>? userErrors { get; set; } = null;
}