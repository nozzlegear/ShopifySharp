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
/// A delivery promise provider. Currently restricted to select approved delivery promise partners.
/// </summary>
public record DeliveryPromiseProvider : IGraphQLObject, INode
{
    /// <summary>
    /// Whether the delivery promise provider is active. Defaults to `true` when creating a provider.
    /// </summary>
    [JsonPropertyName("active")]
    public bool? active { get; set; } = null;

    /// <summary>
    /// The number of seconds to add to the current time as a buffer when looking up
    /// delivery promises. Represents how long the shop requires before releasing an
    /// order to the fulfillment provider.
    /// </summary>
    [JsonPropertyName("fulfillmentDelay")]
    public int? fulfillmentDelay { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The location associated with this delivery promise provider.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The time zone to be used for interpreting day of week and cutoff times in
    /// delivery schedules when looking up delivery promises.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? timeZone { get; set; } = null;
}