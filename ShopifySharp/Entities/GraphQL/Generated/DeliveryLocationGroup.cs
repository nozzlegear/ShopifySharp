#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A location group is a collection of locations. They share zones and delivery methods across delivery
/// profiles.
/// </summary>
public record DeliveryLocationGroup : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A list of all locations that are part of this location group.
    /// </summary>
    [JsonPropertyName("locations")]
    public LocationConnection? locations { get; set; } = null;

    /// <summary>
    /// A count of all locations that are part of this location group.
    /// </summary>
    [JsonPropertyName("locationsCount")]
    public Count? locationsCount { get; set; } = null;
}