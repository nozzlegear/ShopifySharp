#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A participant defines carrier-calculated rates for shipping services
/// with a possible merchant-defined fixed fee or a percentage-of-rate fee.
/// </summary>
public record DeliveryParticipant : IGraphQLUnionCase, IGraphQLObject, INode
{
    /// <summary>
    /// Whether to display new shipping services automatically to the customer when the service becomes available.
    /// </summary>
    [JsonPropertyName("adaptToNewServicesFlag")]
    public bool? adaptToNewServicesFlag { get; set; } = null;

    /// <summary>
    /// The carrier used for this participant.
    /// </summary>
    [JsonPropertyName("carrierService")]
    public DeliveryCarrierService? carrierService { get; set; } = null;

    /// <summary>
    /// The merchant-defined fixed fee for this participant.
    /// </summary>
    [JsonPropertyName("fixedFee")]
    public MoneyV2? fixedFee { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The carrier-specific services offered by the participant, and whether each service is active.
    /// </summary>
    [JsonPropertyName("participantServices")]
    public ICollection<DeliveryParticipantService>? participantServices { get; set; } = null;

    /// <summary>
    /// The merchant-defined percentage-of-rate fee for this participant.
    /// </summary>
    [JsonPropertyName("percentageOfRateFee")]
    public decimal? percentageOfRateFee { get; set; } = null;
}