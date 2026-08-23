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
/// A rate group for a carrier-calculated shipping option.
/// Sets the carrier service, rate adjustments,
/// and carrier-provided services offered at checkout.
/// </summary>
public record DeliveryCarrierCalculatedRateGroup : IGraphQLObject, IDeliveryOptionDefinitionRateGroup
{
    /// <summary>
    /// The flat amount added to or subtracted from carrier rates.
    /// </summary>
    [JsonPropertyName("absoluteAdjustment")]
    public MoneyV2? absoluteAdjustment { get; set; } = null;

    /// <summary>
    /// Whether new services from this carrier are automatically included at checkout.
    /// When true, buyers see any service that isn't excluded.
    /// When false, buyers see only included services.
    /// </summary>
    [JsonPropertyName("autoIncludeNewServices")]
    public bool? autoIncludeNewServices { get; set; } = null;

    /// <summary>
    /// The carrier service that provides rates for this rate group.
    /// </summary>
    [JsonPropertyName("carrierService")]
    public DeliveryCarrierService? carrierService { get; set; } = null;

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
    /// The percentage added to or subtracted from carrier rates.
    /// Applied after `absoluteAdjustment`. A value of 10 means +10%.
    /// </summary>
    [JsonPropertyName("percentageAdjustment")]
    public int? percentageAdjustment { get; set; } = null;

    /// <summary>
    /// Carrier-provided services included or excluded for this rate group.
    /// </summary>
    [JsonPropertyName("serviceConfiguration")]
    public ICollection<DeliveryCarrierCalculatedRateGroupService>? serviceConfiguration { get; set; } = null;
}