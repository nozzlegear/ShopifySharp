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
/// The input fields for generating staged upload targets.
/// </summary>
public record StagedUploadInput : GraphQLInputObject<StagedUploadInput>
{
    /// <summary>
    /// The file's name and extension.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? filename { get; set; } = null;

    /// <summary>
    /// The size of the file to upload, in bytes. This is required when the request's resource property is set to
    /// [VIDEO](https://shopify.dev/api/admin-graphql/latest/enums/StagedUploadTargetGenerateUploadResource#value-video)
    /// or [MODEL_3D](https://shopify.dev/api/admin-graphql/latest/enums/StagedUploadTargetGenerateUploadResource#value-model3d).
    /// </summary>
    [JsonPropertyName("fileSize")]
    public ulong? fileSize { get; set; } = null;

    /// <summary>
    /// The HTTP method to be used when sending a request to upload the file using the returned staged
    /// upload target.
    /// </summary>
    [JsonPropertyName("httpMethod")]
    public StagedUploadHttpMethodType? httpMethod { get; set; } = null;

    /// <summary>
    /// The file's MIME type.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? mimeType { get; set; } = null;

    /// <summary>
    /// The file's intended Shopify resource type.
    /// </summary>
    [JsonPropertyName("resource")]
    public StagedUploadTargetGenerateUploadResource? resource { get; set; } = null;
}