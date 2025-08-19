#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `stagedUploadTargetGenerate` mutation.
/// </summary>
public record StagedUploadTargetGeneratePayload : IGraphQLObject
{
    /// <summary>
    /// The signed parameters that can be used to upload the asset.
    /// </summary>
    [JsonPropertyName("parameters")]
    public ICollection<MutationsStagedUploadTargetGenerateUploadParameter>? parameters { get; set; } = null;

    /// <summary>
    /// The signed URL where the asset can be uploaded.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}