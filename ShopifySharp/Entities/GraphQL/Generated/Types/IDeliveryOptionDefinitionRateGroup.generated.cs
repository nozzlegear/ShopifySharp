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
/// A delivery rate group within an option definition.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DeliveryCarrierCalculatedRateGroup), typeDiscriminator: "DeliveryCarrierCalculatedRateGroup")]
[JsonDerivedType(typeof(DeliveryFlatRateGroup), typeDiscriminator: "DeliveryFlatRateGroup")]
[JsonDerivedType(typeof(DeliveryValueBasedRateGroup), typeDiscriminator: "DeliveryValueBasedRateGroup")]
[JsonDerivedType(typeof(DeliveryWeightBasedRateGroup), typeDiscriminator: "DeliveryWeightBasedRateGroup")]
public interface IDeliveryOptionDefinitionRateGroup : IGraphQLObject
{
    /// <summary>
    /// Conditions that scope this rate group to specific collections or origin locations.
    /// </summary>
    [JsonPropertyName("conditions")]
    public DeliveryRateGroupConditions? conditions { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }
}