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
/// The original source for an image.
/// </summary>
public record MediaImageOriginalSource : IGraphQLObject
{
    /// <summary>
    /// The size of the original file in bytes.
    /// </summary>
    [JsonPropertyName("fileSize")]
    public int? fileSize { get; set; } = null;

    /// <summary>
    /// The URL of the original image, valid only for a short period.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}