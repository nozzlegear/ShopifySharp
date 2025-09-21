#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A source for a Shopify-hosted 3d model.
/// Types of sources include GLB and USDZ formatted 3d models, where the former
/// is an original 3d model and the latter has been converted from the original.
/// If the original source is in GLB format and over 15 MBs in size, then both the
/// original and the USDZ formatted source are optimized to reduce the file size.
/// </summary>
public record Model3dSource : IGraphQLObject
{
    /// <summary>
    /// The 3d model source's filesize.
    /// </summary>
    [JsonPropertyName("filesize")]
    public int? filesize { get; set; } = null;

    /// <summary>
    /// The 3d model source's format.
    /// </summary>
    [JsonPropertyName("format")]
    public string? format { get; set; } = null;

    /// <summary>
    /// The 3d model source's MIME type.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? mimeType { get; set; } = null;

    /// <summary>
    /// The 3d model source's URL.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}