#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A signed upload parameter for uploading an asset to Shopify.
/// Deprecated in favor of
/// [StagedUploadParameter](https://shopify.dev/api/admin-graphql/latest/objects/StagedUploadParameter),
/// which is used in
/// [StagedMediaUploadTarget](https://shopify.dev/api/admin-graphql/latest/objects/StagedMediaUploadTarget)
/// and returned by the
/// [stagedUploadsCreate mutation](https://shopify.dev/api/admin-graphql/latest/mutations/stagedUploadsCreate).
/// </summary>
public record MutationsStagedUploadTargetGenerateUploadParameter : IGraphQLObject
{
    /// <summary>
    /// The upload parameter name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The upload parameter value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}