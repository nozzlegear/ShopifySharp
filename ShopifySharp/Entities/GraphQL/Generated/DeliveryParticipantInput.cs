#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a participant.
/// </summary>
public record DeliveryParticipantInput : GraphQLInputObject<DeliveryParticipantInput>
{
    /// <summary>
    /// Whether to automatically display new shipping services to the customer when a service becomes available.
    /// </summary>
    [JsonPropertyName("adaptToNewServices")]
    public bool? adaptToNewServices { get; set; } = null;

    /// <summary>
    /// The ID of the carrier service for this participant.
    /// </summary>
    [JsonPropertyName("carrierServiceId")]
    public string? carrierServiceId { get; set; } = null;

    /// <summary>
    /// The fixed feed that's defined by the merchant for this participant.
    /// </summary>
    [JsonPropertyName("fixedFee")]
    public MoneyInput? fixedFee { get; set; } = null;

    /// <summary>
    /// The ID of the participant.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of shipping services offered by the participant.
    /// </summary>
    [JsonPropertyName("participantServices")]
    public ICollection<DeliveryParticipantServiceInput>? participantServices { get; set; } = null;

    /// <summary>
    /// The merchant-defined percentage-of-rate fee for this participant.
    /// </summary>
    [JsonPropertyName("percentageOfRateFee")]
    public decimal? percentageOfRateFee { get; set; } = null;
}