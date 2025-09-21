#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `fileAcknowledgeUpdateFailed` mutation.
/// </summary>
public record FileAcknowledgeUpdateFailedPayload : IGraphQLObject
{
    /// <summary>
    /// The updated file(s).
    /// </summary>
    [JsonPropertyName("files")]
    public ICollection<IFile>? files { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FilesUserError>? userErrors { get; set; } = null;
}