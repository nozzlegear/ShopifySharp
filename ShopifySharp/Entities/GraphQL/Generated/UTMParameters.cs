#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a set of UTM parameters.
/// </summary>
public record UTMParameters : IGraphQLObject
{
    /// <summary>
    /// The name of a marketing campaign.
    /// </summary>
    [JsonPropertyName("campaign")]
    public string? campaign { get; set; } = null;

    /// <summary>
    /// Identifies specific content in a marketing campaign. Used to differentiate
    /// between similar content or links in a marketing campaign to determine which is
    /// the most effective.
    /// </summary>
    [JsonPropertyName("content")]
    public string? content { get; set; } = null;

    /// <summary>
    /// The medium of a marketing campaign, such as a banner or email newsletter.
    /// </summary>
    [JsonPropertyName("medium")]
    public string? medium { get; set; } = null;

    /// <summary>
    /// The source of traffic to the merchant's store, such as Google or an email newsletter.
    /// </summary>
    [JsonPropertyName("source")]
    public string? source { get; set; } = null;

    /// <summary>
    /// Paid search terms used by a marketing campaign.
    /// </summary>
    [JsonPropertyName("term")]
    public string? term { get; set; } = null;
}