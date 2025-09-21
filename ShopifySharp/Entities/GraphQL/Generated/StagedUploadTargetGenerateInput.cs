#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The required fields and parameters to generate the URL upload an"
/// asset to Shopify.
/// Deprecated in favor of
/// [StagedUploadInput](https://shopify.dev/api/admin-graphql/latest/objects/StagedUploadInput),
/// which is used by the
/// [stagedUploadsCreate mutation](https://shopify.dev/api/admin-graphql/latest/mutations/stagedUploadsCreate).
/// </summary>
public record StagedUploadTargetGenerateInput : GraphQLInputObject<StagedUploadTargetGenerateInput>
{
    /// <summary>
    /// The filename of the asset being uploaded.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? filename { get; set; } = null;

    /// <summary>
    /// The size of the file to upload, in bytes.
    /// </summary>
    [JsonPropertyName("fileSize")]
    public ulong? fileSize { get; set; } = null;

    /// <summary>
    /// The HTTP method to be used by the staged upload.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public StagedUploadHttpMethodType? httpMethod { get; set; } = null;

    /// <summary>
    /// The MIME type of the asset being uploaded.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? mimeType { get; set; } = null;

    /// <summary>
    /// The resource type being uploaded.
    /// </summary>
    [JsonPropertyName("resource")]
    public StagedUploadTargetGenerateUploadResource? resource { get; set; } = null;
}