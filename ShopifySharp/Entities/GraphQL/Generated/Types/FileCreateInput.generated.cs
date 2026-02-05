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
/// The input fields that are required to create a file object.
/// </summary>
public record FileCreateInput : GraphQLInputObject<FileCreateInput>
{
    /// <summary>
    /// The alt text description of the file for screen readers and accessibility.
    /// </summary>
    [JsonPropertyName("alt")]
    public string? alt { get; set; } = null;

    /// <summary>
    /// The file content type. If omitted, then Shopify will attempt to determine the content type during file processing.
    /// </summary>
    [JsonPropertyName("contentType")]
    public FileContentType? contentType { get; set; } = null;

    /// <summary>
    /// How to handle if filename is already in use.
    /// </summary>
    [JsonPropertyName("duplicateResolutionMode")]
    public FileCreateInputDuplicateResolutionMode? duplicateResolutionMode { get; set; } = null;

    /// <summary>
    /// The name of the file. If provided, then the file is created with the specified filename.
    /// If not provided, then the filename from the `originalSource` is used.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? filename { get; set; } = null;

    /// <summary>
    /// An external URL (for images only) or a
    /// [staged upload URL](https://shopify.dev/api/admin-graphql/latest/mutations/stageduploadscreate).
    /// </summary>
    [JsonPropertyName("originalSource")]
    public string? originalSource { get; set; } = null;
}