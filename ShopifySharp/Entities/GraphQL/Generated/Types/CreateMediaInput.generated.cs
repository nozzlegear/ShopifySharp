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
/// The input fields required to create a media object.
/// </summary>
public record CreateMediaInput : GraphQLInputObject<CreateMediaInput>
{
    /// <summary>
    /// The alt text associated with the media.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; } = null;

    /// <summary>
    /// The media content type.
    /// </summary>
    [JsonPropertyName("mediaContentType")]
    public MediaContentType? mediaContentType { get; set; } = null;

    /// <summary>
    /// The original source of the media object. This might be an external URL or a staged upload URL.
    /// </summary>
    [JsonPropertyName("originalSource")]
    public string? originalSource { get; set; } = null;
}