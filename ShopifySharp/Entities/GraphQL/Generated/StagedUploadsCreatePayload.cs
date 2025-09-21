#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `stagedUploadsCreate` mutation.
/// </summary>
public record StagedUploadsCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The staged upload targets that were generated.
    /// </summary>
    [JsonPropertyName("stagedTargets")]
    public ICollection<StagedMediaUploadTarget>? stagedTargets { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}