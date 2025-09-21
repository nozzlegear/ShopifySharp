#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to use to edit a location.
/// </summary>
public record LocationEditInput : GraphQLInputObject<LocationEditInput>
{
    /// <summary>
    /// The address of the location.
    /// </summary>
    [JsonPropertyName("address")]
    public LocationEditAddressInput? address { get; set; } = null;

    /// <summary>
    /// Whether inventory at this location is available for sale online.
    /// **Note:** This can't be disabled for fulfillment service locations.
    /// </summary>
    [JsonPropertyName("fulfillsOnlineOrders")]
    public bool? fulfillsOnlineOrders { get; set; } = null;

    /// <summary>
    /// Additional customizable information to associate with the location.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The name of the location.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}