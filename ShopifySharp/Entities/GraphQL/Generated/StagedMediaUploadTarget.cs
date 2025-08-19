#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Information about a staged upload target, which should be used to send a request to upload
/// the file.
/// For more information on the upload process, refer to
/// [Upload media to Shopify](https://shopify.dev/apps/online-store/media/products#step-1-upload-media-to-shopify).
/// </summary>
public record StagedMediaUploadTarget : IGraphQLObject
{
    /// <summary>
    /// Parameters needed to authenticate a request to upload the file.
    /// </summary>
    [JsonPropertyName("parameters")]
    public ICollection<StagedUploadParameter>? parameters { get; set; } = null;

    /// <summary>
    /// The URL to be passed as `originalSource` in
    /// [CreateMediaInput](https://shopify.dev/api/admin-graphql/latest/input-objects/CreateMediaInput)
    /// and [FileCreateInput](https://shopify.dev/api/admin-graphql/2022-04/input-objects/FileCreateInput)
    /// for the [productCreateMedia](https://shopify.dev/api/admin-graphql/2022-04/mutations/productCreateMedia)
    /// and [fileCreate](https://shopify.dev/api/admin-graphql/2022-04/mutations/fileCreate)
    /// mutations.
    /// </summary>
    [JsonPropertyName("resourceUrl")]
    public string? resourceUrl { get; set; } = null;

    /// <summary>
    /// The URL to use when sending an request to upload the file. Should be used in conjunction with
    /// the parameters field.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}