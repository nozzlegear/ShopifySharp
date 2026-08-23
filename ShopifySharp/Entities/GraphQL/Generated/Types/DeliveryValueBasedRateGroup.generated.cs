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
/// A rate group for a value-based shipping option.
/// Contains rates that define price tiers based on cart value.
/// </summary>
public record DeliveryValueBasedRateGroup : IGraphQLObject, IDeliveryOptionDefinitionRateGroup
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
    /// The value-based rates in this rate group.
    /// </summary>
    [JsonPropertyName("rates")]
    public DeliveryValueBasedRateConnection? rates { get; set; } = null;
}