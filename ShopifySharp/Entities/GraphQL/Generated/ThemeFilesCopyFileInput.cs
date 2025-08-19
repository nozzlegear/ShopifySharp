#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the file copy.
/// </summary>
public record ThemeFilesCopyFileInput : GraphQLInputObject<ThemeFilesCopyFileInput>
{
    /// <summary>
    /// The new file where the content is copied to.
    /// </summary>
    [JsonPropertyName("dstFilename")]
    public string? dstFilename { get; set; } = null;

    /// <summary>
    /// The source file to copy from.
    /// </summary>
    [JsonPropertyName("srcFilename")]
    public string? srcFilename { get; set; } = null;
}