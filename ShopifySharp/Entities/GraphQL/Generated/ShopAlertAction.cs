#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An action associated to a shop alert, such as adding a credit card.
/// </summary>
public record ShopAlertAction : IGraphQLObject
{
    /// <summary>
    /// The text for the button in the alert. For example, _Add credit card_.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The target URL that the button links to.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}