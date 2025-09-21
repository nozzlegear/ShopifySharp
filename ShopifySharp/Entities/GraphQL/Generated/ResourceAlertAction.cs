#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An action associated to a resource alert, such as editing variants.
/// </summary>
public record ResourceAlertAction : IGraphQLObject
{
    /// <summary>
    /// Whether the action appears as a button or as a link.
    /// </summary>
    [JsonPropertyName("primary")]
    public bool? primary { get; set; } = null;

    /// <summary>
    /// Resource for the action to show.
    /// </summary>
    [JsonPropertyName("show")]
    public string? show { get; set; } = null;

    /// <summary>
    /// The text for the button in the alert. For example, _Edit variants_.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The target URL that the button links to.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}