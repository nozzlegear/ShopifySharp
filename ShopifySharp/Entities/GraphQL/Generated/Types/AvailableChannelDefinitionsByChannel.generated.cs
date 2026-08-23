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
    [Obsolete("Use [`QueryRoot.orderAttributionDefinitions`](https://shopify.dev/docs/api/admin-graphql/latest/queries/orderAttributionDefinitions) and select `id`, `handle`, `displayName`, and `icon` instead.")]
    public ICollection<ChannelDefinition>? channelDefinitions { get; set; } = null;

    /// <summary>
    /// The name of the channel.
    /// </summary>
    [JsonPropertyName("channelName")]
    [Obsolete("Use [`OrderAttributionDefinition.displayName`](https://shopify.dev/docs/api/admin-graphql/latest/objects/OrderAttributionDefinition#field-OrderAttributionDefinition.fields.displayName) instead.")]
    public string? channelName { get; set; } = null;
}