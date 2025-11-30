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
/// Represents an object containing all information for channels available to a shop.
/// </summary>
public record AvailableChannelDefinitionsByChannel : IGraphQLObject
{
    /// <summary>
    /// The channel definitions for channels installed on a shop.
    /// </summary>
    [JsonPropertyName("channelDefinitions")]
    public ICollection<ChannelDefinition>? channelDefinitions { get; set; } = null;

    /// <summary>
    /// The name of the channel.
    /// </summary>
    [JsonPropertyName("channelName")]
    public string? channelName { get; set; } = null;
}