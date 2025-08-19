#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An alert message that appears in the Shopify admin about a problem with a store
/// resource, with 1 or more actions to take. For example, you could use an alert to
/// indicate that you're not charging taxes on some product variants.
/// They can optionally have a specific icon and be dismissed by merchants.
/// </summary>
public record ResourceAlert : IGraphQLObject
{
    /// <summary>
    /// Buttons in the alert that link to related information.
    /// For example, _Edit variants_.
    /// </summary>
    [JsonPropertyName("actions")]
    public ICollection<ResourceAlertAction>? actions { get; set; } = null;

    /// <summary>
    /// The secondary text in the alert that includes further information or instructions about how to solve a problem.
    /// </summary>
    [JsonPropertyName("content")]
    public string? content { get; set; } = null;

    /// <summary>
    /// Unique identifier that appears when an alert is manually closed by the merchant.
    /// Most alerts can't be manually closed.
    /// </summary>
    [JsonPropertyName("dismissibleHandle")]
    public string? dismissibleHandle { get; set; } = null;

    /// <summary>
    /// An icon that's optionally displayed with the alert.
    /// </summary>
    [JsonPropertyName("icon")]
    public ResourceAlertIcon? icon { get; set; } = null;

    /// <summary>
    /// Indication of how important the alert is.
    /// </summary>
    [JsonPropertyName("severity")]
    public ResourceAlertSeverity? severity { get; set; } = null;

    /// <summary>
    /// The primary text in the alert that includes information or describes the problem.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}