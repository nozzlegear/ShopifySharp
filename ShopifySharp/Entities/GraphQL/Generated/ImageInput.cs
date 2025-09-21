#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an image.
/// </summary>
public record ImageInput : GraphQLInputObject<ImageInput>
{
    /// <summary>
    /// A word or phrase to share the nature or contents of an image.
    /// </summary>
    [JsonPropertyName("altText")]
    public string? altText { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The URL of the image. May be a staged upload URL.
    /// </summary>
    [JsonPropertyName("src")]
    public string? src { get; set; } = null;
}