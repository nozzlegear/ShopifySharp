#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to update a media object.
/// </summary>
public record UpdateMediaInput : GraphQLInputObject<UpdateMediaInput>
{
    /// <summary>
    /// The alt text associated to the media.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; } = null;

    /// <summary>
    /// Specifies the media to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The source from which to update the media preview image. May be an external URL or staged upload URL.
    /// </summary>
    [JsonPropertyName("previewImageSource")]
    public string? previewImageSource { get; set; } = null;
}