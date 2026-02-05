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
/// Return type for `fileUpdate` mutation.
/// </summary>
public record FileUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The list of updated files.
    /// </summary>
    [JsonPropertyName("files")]
    public ICollection<IFile>? files { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FilesUserError>? userErrors { get; set; } = null;
}