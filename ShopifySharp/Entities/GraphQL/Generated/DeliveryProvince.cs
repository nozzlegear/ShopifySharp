#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A region that is used to define a shipping zone.
/// </summary>
public record DeliveryProvince : IGraphQLObject, INode
{
    /// <summary>
    /// The code of the region.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The full name of the region.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The translated name of the region. The translation returned is based on the system's locale.
    /// </summary>
    [JsonPropertyName("translatedName")]
    public string? translatedName { get; set; } = null;
}