#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A zone is a group of countries that have the same shipping rates. Customers can
/// order products from a store only if they choose a shipping destination that's
/// included in one of the store's zones.
/// </summary>
public record DeliveryZone : IGraphQLObject, INode
{
    /// <summary>
    /// The list of countries within the zone.
    /// </summary>
    [JsonPropertyName("countries")]
    public ICollection<DeliveryCountry>? countries { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}