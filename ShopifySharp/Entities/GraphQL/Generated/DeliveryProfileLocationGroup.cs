#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Links a location group with zones. Both are associated to a delivery profile.
/// </summary>
public record DeliveryProfileLocationGroup : IGraphQLObject
{
    /// <summary>
    /// The countries already selected in any zone for the specified location group.
    /// </summary>
    [JsonPropertyName("countriesInAnyZone")]
    public ICollection<DeliveryCountryAndZone>? countriesInAnyZone { get; set; } = null;

    /// <summary>
    /// The collection of locations that make up the specified location group.
    /// </summary>
    [JsonPropertyName("locationGroup")]
    public DeliveryLocationGroup? locationGroup { get; set; } = null;

    /// <summary>
    /// The applicable zones associated to the specified location group.
    /// </summary>
    [JsonPropertyName("locationGroupZones")]
    public DeliveryLocationGroupZoneConnection? locationGroupZones { get; set; } = null;
}