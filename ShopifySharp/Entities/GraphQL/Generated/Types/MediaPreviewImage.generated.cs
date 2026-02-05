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
/// Represents the preview image for a media.
/// </summary>
public record MediaPreviewImage : IGraphQLObject
{
    /// <summary>
    /// The preview image for the media. Returns `null` until `status` is `READY`.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// Current status of the preview image.
    /// </summary>
    [JsonPropertyName("status")]
    public MediaPreviewImageStatus? status { get; set; } = null;
}