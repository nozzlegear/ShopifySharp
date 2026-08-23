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
/// The input fields for creating a flat rate group.
/// </summary>
public record DeliveryFlatRateGroupCreateInput : GraphQLInputObject<DeliveryFlatRateGroupCreateInput>
{
    /// <summary>
    /// Collection and origin location conditions for this rate group.
    /// </summary>
    [JsonPropertyName("conditions")]
    public DeliveryRateConditionsCreateInput? conditions { get; set; } = null;

    /// <summary>
    /// The fixed-price rate and optional transit time.
    /// </summary>
    [JsonPropertyName("rate")]
    public DeliveryFlatRateCreateInput? rate { get; set; } = null;
}