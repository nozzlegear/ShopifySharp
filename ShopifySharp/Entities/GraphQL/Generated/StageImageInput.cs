#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An image to be uploaded.
/// Deprecated in favor of
/// [StagedUploadInput](https://shopify.dev/api/admin-graphql/latest/objects/StagedUploadInput),
/// which is used by the
/// [stagedUploadsCreate mutation](https://shopify.dev/api/admin-graphql/latest/mutations/stagedUploadsCreate).
/// </summary>
public record StageImageInput : GraphQLInputObject<StageImageInput>
{
    /// <summary>
    /// The image filename.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? filename { get; set; } = null;

    /// <summary>
    /// HTTP method to be used by the staged upload.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public StagedUploadHttpMethodType? httpMethod { get; set; } = null;

    /// <summary>
    /// The image MIME type.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? mimeType { get; set; } = null;

    /// <summary>
    /// The image resource.
    /// </summary>
    [JsonPropertyName("resource")]
    public StagedUploadTargetGenerateUploadResource? resource { get; set; } = null;
}