#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Information about the staged target.
/// Deprecated in favor of
/// [StagedMediaUploadTarget](https://shopify.dev/api/admin-graphql/latest/objects/StagedMediaUploadTarget),
/// which is returned by the
/// [stagedUploadsCreate mutation](https://shopify.dev/api/admin-graphql/latest/mutations/stagedUploadsCreate).
/// </summary>
public record StagedUploadTarget : IGraphQLObject
{
    /// <summary>
    /// The parameters of an image to be uploaded.
    /// </summary>
    [JsonPropertyName("parameters")]
    public ICollection<ImageUploadParameter>? parameters { get; set; } = null;

    /// <summary>
    /// The image URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}