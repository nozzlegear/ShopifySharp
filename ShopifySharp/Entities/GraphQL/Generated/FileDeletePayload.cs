#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `fileDelete` mutation.
/// </summary>
public record FileDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The IDs of the deleted files.
    /// </summary>
    [JsonPropertyName("deletedFileIds")]
    public ICollection<string>? deletedFileIds { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FilesUserError>? userErrors { get; set; } = null;
}