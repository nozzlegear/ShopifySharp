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
/// The input fields for creating a shipping option. Provide exactly one option type.
/// </summary>
public record DeliveryOptionDefinitionCreateInput : GraphQLInputObject<DeliveryOptionDefinitionCreateInput>
{
    /// <summary>
    /// A carrier-calculated shipping option.
    /// </summary>
    [JsonPropertyName("carrierCalculated")]
    public DeliveryCarrierCalculatedOptionDefinitionCreateInput? carrierCalculated { get; set; } = null;

    /// <summary>
    /// A flat rate shipping option.
    /// </summary>
    [JsonPropertyName("flatRate")]
    public DeliveryFlatRateOptionDefinitionCreateInput? flatRate { get; set; } = null;

    /// <summary>
    /// A value-based shipping option.
    /// </summary>
    [JsonPropertyName("valueBased")]
    public DeliveryValueBasedOptionDefinitionCreateInput? valueBased { get; set; } = null;

    /// <summary>
    /// A weight-based shipping option.
    /// </summary>
    [JsonPropertyName("weightBased")]
    public DeliveryWeightBasedOptionDefinitionCreateInput? weightBased { get; set; } = null;
}