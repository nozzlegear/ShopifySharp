#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `stagedUploadTargetsGenerate` mutation.
/// </summary>
public record StagedUploadTargetsGeneratePayload : IGraphQLObject
{
    /// <summary>
    /// The staged upload targets that were generated.
    /// </summary>
    [JsonPropertyName("urls")]
    public ICollection<StagedUploadTarget>? urls { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}