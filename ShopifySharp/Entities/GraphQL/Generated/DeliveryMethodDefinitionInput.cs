#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a method definition.
/// </summary>
public record DeliveryMethodDefinitionInput : GraphQLInputObject<DeliveryMethodDefinitionInput>
{
    /// <summary>
    /// Whether to use this method definition during rate calculation.
    /// </summary>
    [JsonPropertyName("active")]
    public bool? active { get; set; } = null;

    /// <summary>
    /// A list of conditions to update on the method definition.
    /// </summary>
    [JsonPropertyName("conditionsToUpdate")]
    public ICollection<DeliveryUpdateConditionInput>? conditionsToUpdate { get; set; } = null;

    /// <summary>
    /// The description of the method definition.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID of the method definition. Use only when updating a method definition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the method definition.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A participant to apply to the method definition.
    /// </summary>
    [JsonPropertyName("participant")]
    public DeliveryParticipantInput? participant { get; set; } = null;

    /// <summary>
    /// A list of price conditions on the method definition.
    /// </summary>
    [JsonPropertyName("priceConditionsToCreate")]
    public ICollection<DeliveryPriceConditionInput>? priceConditionsToCreate { get; set; } = null;

    /// <summary>
    /// A rate definition to apply to the method definition.
    /// </summary>
    [JsonPropertyName("rateDefinition")]
    public DeliveryRateDefinitionInput? rateDefinition { get; set; } = null;

    /// <summary>
    /// A list of weight conditions on the method definition.
    /// </summary>
    [JsonPropertyName("weightConditionsToCreate")]
    public ICollection<DeliveryWeightConditionInput>? weightConditionsToCreate { get; set; } = null;
}