#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Provides attributes for visual representation.
/// </summary>
public record MetaobjectThumbnail : IGraphQLObject
{
    /// <summary>
    /// The file to be used for visual representation of this metaobject.
    /// </summary>
    [JsonPropertyName("file")]
    public IFile? file { get; set; } = null;

    /// <summary>
    /// The hexadecimal color code to be used for respresenting this metaobject.
    /// </summary>
    [JsonPropertyName("hex")]
    public string? hex { get; set; } = null;
}