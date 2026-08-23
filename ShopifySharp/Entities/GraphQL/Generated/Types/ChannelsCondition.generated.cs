#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A condition checking the channel that the visitor is shopping from.
/// </summary>
public record ChannelsCondition : IGraphQLObject
{
    /// <summary>
    /// The application level for the condition.
    /// </summary>
    [JsonPropertyName("applicationLevel")]
    public MarketConditionApplicationType? applicationLevel { get; set; } = null;

    /// <summary>
    /// The channels that comprise the market.
    /// </summary>
    [JsonPropertyName("channels")]
    public ChannelConnection? channels { get; set; } = null;

    /// <summary>
    /// The total number of channels condition.
    /// </summary>
    [JsonPropertyName("channelsCount")]
    public Count? channelsCount { get; set; } = null;
}