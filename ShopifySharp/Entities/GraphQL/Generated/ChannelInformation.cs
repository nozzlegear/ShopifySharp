#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Contains the information for a given sales channel.
/// </summary>
public record ChannelInformation : IGraphQLObject, INode
{
    /// <summary>
    /// The app associated with the channel.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The channel definition associated with the channel.
    /// </summary>
    [JsonPropertyName("channelDefinition")]
    public ChannelDefinition? channelDefinition { get; set; } = null;

    /// <summary>
    /// The unique ID for the channel.
    /// </summary>
    [JsonPropertyName("channelId")]
    public string? channelId { get; set; } = null;

    /// <summary>
    /// The publishing destination display name or channel name.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}