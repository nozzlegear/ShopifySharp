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
/// The input fields for updating a rate group for a carrier-calculated shipping option.
/// </summary>
public record DeliveryCarrierCalculatedRateGroupUpdateInput : GraphQLInputObject<DeliveryCarrierCalculatedRateGroupUpdateInput>
{
    /// <summary>
    /// The flat amount added to or subtracted from carrier rates.
    /// </summary>
    [JsonPropertyName("absoluteAdjustment")]
    public MoneyInput? absoluteAdjustment { get; set; } = null;

    /// <summary>
    /// Whether new services from this carrier are automatically included at checkout.
    /// When true, buyers see any service that isn't excluded.
    /// When false, buyers see only included services.
    /// </summary>
    [JsonPropertyName("autoIncludeNewServices")]
    public bool? autoIncludeNewServices { get; set; } = null;

    /// <summary>
    /// The ID of the carrier service that provides rates for this shipping option.
    /// </summary>
    [JsonPropertyName("carrierServiceId")]
    public string? carrierServiceId { get; set; } = null;

    /// <summary>
    /// Collection and origin location conditions for this rate group.
    /// </summary>
    [JsonPropertyName("conditions")]
    public DeliveryRateConditionsUpdateInput? conditions { get; set; } = null;

    /// <summary>
    /// The ID of the rate group to update
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The percentage added to or subtracted from carrier rates.
    /// </summary>
    [JsonPropertyName("percentageAdjustment")]
    public int? percentageAdjustment { get; set; } = null;

    /// <summary>
    /// Carrier-provided services to include or exclude. Replaces the existing configuration.
    /// </summary>
    [JsonPropertyName("serviceConfiguration")]
    public ICollection<DeliveryCarrierCalculatedRateGroupServiceInput>? serviceConfiguration { get; set; } = null;
}