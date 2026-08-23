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
/// The input fields required to create or update a channel market condition.
/// </summary>
public record MarketConditionsChannelsInput : GraphQLInputObject<MarketConditionsChannelsInput>
{
    /// <summary>
    /// A list of channel IDs to include in the market condition.
    /// </summary>
    [JsonPropertyName("channelIds")]
    public ICollection<string>? channelIds { get; set; } = null;
}