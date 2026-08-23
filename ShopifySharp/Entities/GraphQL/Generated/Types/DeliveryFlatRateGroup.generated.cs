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
/// A flat rate group for a shipping option.
/// Contains one fixed-price rate and optional collection or origin location conditions.
/// </summary>
public record DeliveryFlatRateGroup : IGraphQLObject, IDeliveryOptionDefinitionRateGroup
{
    /// <summary>
    /// Conditions that limit this rate group to specific collections or origin locations.
    /// </summary>
    [JsonPropertyName("conditions")]
    public DeliveryRateGroupConditions? conditions { get; set; } = null;

    /// <summary>
    /// A globally unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The fixed-price rate and optional transit time.
    /// </summary>
    [JsonPropertyName("rate")]
    public DeliveryFlatRate? rate { get; set; } = null;
}