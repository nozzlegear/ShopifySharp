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
/// The input fields for updating a shipping option. Provide exactly one option type.
/// </summary>
public record DeliveryOptionDefinitionUpdateInput : GraphQLInputObject<DeliveryOptionDefinitionUpdateInput>
{
    /// <summary>
    /// A carrier-calculated shipping option to update.
    /// </summary>
    [JsonPropertyName("carrierCalculated")]
    public DeliveryCarrierCalculatedOptionDefinitionUpdateInput? carrierCalculated { get; set; } = null;

    /// <summary>
    /// A flat rate shipping option to update.
    /// </summary>
    [JsonPropertyName("flatRate")]
    public DeliveryFlatRateOptionDefinitionUpdateInput? flatRate { get; set; } = null;

    /// <summary>
    /// A value-based shipping option to update.
    /// </summary>
    [JsonPropertyName("valueBased")]
    public DeliveryValueBasedOptionDefinitionUpdateInput? valueBased { get; set; } = null;

    /// <summary>
    /// A weight-based shipping option to update.
    /// </summary>
    [JsonPropertyName("weightBased")]
    public DeliveryWeightBasedOptionDefinitionUpdateInput? weightBased { get; set; } = null;
}