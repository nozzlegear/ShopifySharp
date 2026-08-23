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
/// Conditions that limit a rate group to specific collections or origin locations.
/// When conditions are set, the rate group applies only to matching shipments.
/// </summary>
public record DeliveryRateGroupConditions : IGraphQLObject
{
    /// <summary>
    /// Collections this rate group applies to. Null means the rate group applies to all products.
    /// </summary>
    [JsonPropertyName("collections")]
    public CollectionConnection? collections { get; set; } = null;

    /// <summary>
    /// The number of collections this rate group applies to. Null when it applies to all products.
    /// </summary>
    [JsonPropertyName("collectionsCount")]
    public Count? collectionsCount { get; set; } = null;

    /// <summary>
    /// Origin locations this rate group applies to.
    /// </summary>
    [JsonPropertyName("originLocations")]
    public LocationConnection? originLocations { get; set; } = null;

    /// <summary>
    /// The number of origin locations this rate group applies to.
    /// </summary>
    [JsonPropertyName("originLocationsCount")]
    public Count? originLocationsCount { get; set; } = null;
}