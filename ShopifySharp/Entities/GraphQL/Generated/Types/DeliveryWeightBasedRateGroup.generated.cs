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
/// A rate group for a weight-based shipping option.
/// Contains rates that define price tiers based on package weight.
/// </summary>
public record DeliveryWeightBasedRateGroup : IGraphQLObject, IDeliveryOptionDefinitionRateGroup
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
    /// The weight-based rates in this rate group.
    /// </summary>
    [JsonPropertyName("rates")]
    public DeliveryWeightBasedRateConnection? rates { get; set; } = null;
}