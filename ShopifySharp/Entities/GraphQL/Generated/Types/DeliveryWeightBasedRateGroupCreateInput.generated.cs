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
/// The input fields for creating a weight-based rate group.
/// </summary>
public record DeliveryWeightBasedRateGroupCreateInput : GraphQLInputObject<DeliveryWeightBasedRateGroupCreateInput>
{
    /// <summary>
    /// Collection and origin location conditions for this rate group.
    /// </summary>
    [JsonPropertyName("conditions")]
    public DeliveryRateConditionsCreateInput? conditions { get; set; } = null;

    /// <summary>
    /// The weight-based rates for this rate group.
    /// </summary>
    [JsonPropertyName("rates")]
    public ICollection<DeliveryWeightBasedRateCreateInput>? rates { get; set; } = null;
}