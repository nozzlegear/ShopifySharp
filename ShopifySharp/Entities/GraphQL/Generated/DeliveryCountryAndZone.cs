#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The country details and the associated shipping zone.
/// </summary>
public record DeliveryCountryAndZone : IGraphQLObject
{
    /// <summary>
    /// The country details.
    /// </summary>
    [JsonPropertyName("country")]
    public DeliveryCountry? country { get; set; } = null;

    /// <summary>
    /// The name of the shipping zone.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? zone { get; set; } = null;
}