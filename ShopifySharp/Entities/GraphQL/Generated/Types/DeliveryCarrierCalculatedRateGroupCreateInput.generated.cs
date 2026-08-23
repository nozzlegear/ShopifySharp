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
/// The input fields for creating a rate group for a carrier-calculated shipping option.
/// </summary>
public record DeliveryCarrierCalculatedRateGroupCreateInput : GraphQLInputObject<DeliveryCarrierCalculatedRateGroupCreateInput>
{
    /// <summary>
    /// The flat amount added to or subtracted from carrier rates.
    /// </summary>
    [JsonPropertyName("absoluteAdjustment")]
    public MoneyInput? absoluteAdjustment { get; set; } = null;

    /// <summary>
    /// Whether new services from this carrier are automatically included at checkout.
    /// When omitted, defaults to true. Set to false to offer only explicitly
    /// included services for carriers that support service discovery.
    /// </summary>
    [JsonPropertyName("autoIncludeNewServices")]
    public bool? autoIncludeNewServices { get; set; } = null;

    /// <summary>
    /// The ID of the carrier service to use for this rate group.
    /// </summary>
    [JsonPropertyName("carrierServiceId")]
    public string? carrierServiceId { get; set; } = null;

    /// <summary>
    /// Collection and origin location conditions for this rate group.
    /// </summary>
    [JsonPropertyName("conditions")]
    public DeliveryRateConditionsCreateInput? conditions { get; set; } = null;

    /// <summary>
    /// The percentage added to or subtracted from carrier rates.
    /// </summary>
    [JsonPropertyName("percentageAdjustment")]
    public int? percentageAdjustment { get; set; } = null;

    /// <summary>
    /// Carrier-provided services to include or exclude.
    /// Services not listed follow the default behavior based on `autoIncludeNewServices`.
    /// </summary>
    [JsonPropertyName("serviceConfiguration")]
    public ICollection<DeliveryCarrierCalculatedRateGroupServiceInput>? serviceConfiguration { get; set; } = null;
}