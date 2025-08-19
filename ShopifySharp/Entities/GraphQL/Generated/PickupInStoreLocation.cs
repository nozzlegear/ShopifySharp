#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A location for in-store pickup.
/// </summary>
public record PickupInStoreLocation : IGraphQLObject
{
    /// <summary>
    /// The code of the pickup location.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// Distance from the buyer to the pickup location.
    /// </summary>
    [JsonPropertyName("distanceFromBuyer")]
    public Distance? distanceFromBuyer { get; set; } = null;

    /// <summary>
    /// A unique identifier for this pickup location.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Pickup instructions.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? instructions { get; set; } = null;

    /// <summary>
    /// The location ID of the pickup location.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The source of the pickup location.
    /// </summary>
    [JsonPropertyName("source")]
    public string? source { get; set; } = null;

    /// <summary>
    /// Title of the pickup location.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}