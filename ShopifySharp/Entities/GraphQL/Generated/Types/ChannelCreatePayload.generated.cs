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
/// Return type for `channelCreate` mutation.
/// </summary>
public record ChannelCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The channel that was created.
    /// </summary>
    [JsonPropertyName("channel")]
    public Channel? channel { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ChannelCreateUserError>? userErrors { get; set; } = null;
}