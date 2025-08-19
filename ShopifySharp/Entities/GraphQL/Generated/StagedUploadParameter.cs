#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The parameters required to authenticate a file upload request using a
/// [StagedMediaUploadTarget's url field](https://shopify.dev/api/admin-graphql/latest/objects/StagedMediaUploadTarget#field-stagedmediauploadtarget-url).
/// For more information on the upload process, refer to
/// [Upload media to Shopify](https://shopify.dev/apps/online-store/media/products#step-1-upload-media-to-shopify).
/// </summary>
public record StagedUploadParameter : IGraphQLObject
{
    /// <summary>
    /// The parameter's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The parameter's value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}