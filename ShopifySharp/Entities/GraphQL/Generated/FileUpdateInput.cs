#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields that are required to update a file object.
/// </summary>
public record FileUpdateInput : GraphQLInputObject<FileUpdateInput>
{
    /// <summary>
    /// The alt text description of the file for screen readers and accessibility.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; } = null;

    /// <summary>
    /// The name of the file including its extension.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? filename { get; set; } = null;

    /// <summary>
    /// The ID of the file to be updated.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The source from which to update a media image or generic file.
    /// An external URL (for images only) or a
    /// [staged upload URL](https://shopify.dev/api/admin-graphql/latest/mutations/stageduploadscreate).
    /// </summary>
    [JsonPropertyName("originalSource")]
    public string? originalSource { get; set; } = null;

    /// <summary>
    /// The source from which to update the media preview image.
    /// May be an external URL or a
    /// [staged upload URL](https://shopify.dev/api/admin-graphql/latest/mutations/stageduploadscreate).
    /// </summary>
    [JsonPropertyName("previewImageSource")]
    public string? previewImageSource { get; set; } = null;

    /// <summary>
    /// The IDs of the references to add to the file. Currently only accepts product IDs.
    /// </summary>
    [JsonPropertyName("referencesToAdd")]
    public ICollection<string>? referencesToAdd { get; set; } = null;

    /// <summary>
    /// The IDs of the references to remove from the file. Currently only accepts product IDs.
    /// </summary>
    [JsonPropertyName("referencesToRemove")]
    public ICollection<string>? referencesToRemove { get; set; } = null;
}