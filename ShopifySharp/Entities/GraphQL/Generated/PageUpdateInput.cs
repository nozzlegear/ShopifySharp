#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to update a page.
/// </summary>
public record PageUpdateInput : GraphQLInputObject<PageUpdateInput>
{
    /// <summary>
    /// The text content of the page, complete with HTML markup.
    /// </summary>
    [JsonPropertyName("body")]
    public string? body { get; set; } = null;

    /// <summary>
    /// A unique, human-friendly string for the page. If no handle is specified, a
    /// handle will be generated automatically from the page title.
    /// In themes, the Liquid templating language refers to a page by its handle.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Whether or not the page should be visible. Defaults to `true` if no publish date is specified.
    /// </summary>
    [JsonPropertyName("isPublished")]
    public bool? isPublished { get; set; } = null;

    /// <summary>
    /// The input fields to create or update a metafield.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The date and time (ISO 8601 format) when the page should become visible.
    /// </summary>
    [JsonPropertyName("publishDate")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? publishDate { get; set; } = null;

    /// <summary>
    /// Whether a redirect is required after a new handle has been provided.
    /// If `true`, then the old handle is redirected to the new one automatically.
    /// </summary>
    [JsonPropertyName("redirectNewHandle")]
    public bool? redirectNewHandle { get; set; } = null;

    /// <summary>
    /// The suffix of the template that's used to render the page.
    /// If the value is an empty string or `null`, then the default page template is used.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;

    /// <summary>
    /// The title of the page.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}