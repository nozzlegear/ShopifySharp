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
/// A file interface.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(ExternalVideo), typeDiscriminator: "ExternalVideo")]
[JsonDerivedType(typeof(GenericFile), typeDiscriminator: "GenericFile")]
[JsonDerivedType(typeof(MediaImage), typeDiscriminator: "MediaImage")]
[JsonDerivedType(typeof(Model3d), typeDiscriminator: "Model3d")]
[JsonDerivedType(typeof(Video), typeDiscriminator: "Video")]
public interface IFile : IGraphQLObject
{
    /// <summary>
    /// A word or phrase to describe the contents or the function of a file.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; }

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the file was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; }

    /// <summary>
    /// Any errors that have occurred on the file.
    /// </summary>
    [JsonPropertyName("fileErrors")]
    public ICollection<FileError>? fileErrors { get; set; }

    /// <summary>
    /// The status of the file.
    /// </summary>
    [JsonPropertyName("fileStatus")]
    public FileStatus? fileStatus { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// The preview image for the media.
    /// </summary>
    [JsonPropertyName("preview")]
    public MediaPreviewImage? preview { get; set; }

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the file was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; }
}