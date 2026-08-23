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
/// A shipping option shown to buyers at checkout. Implemented by concrete option types.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DeliveryCarrierCalculatedOptionDefinition), typeDiscriminator: "DeliveryCarrierCalculatedOptionDefinition")]
[JsonDerivedType(typeof(DeliveryFlatRateOptionDefinition), typeDiscriminator: "DeliveryFlatRateOptionDefinition")]
[JsonDerivedType(typeof(DeliveryValueBasedOptionDefinition), typeDiscriminator: "DeliveryValueBasedOptionDefinition")]
[JsonDerivedType(typeof(DeliveryWeightBasedOptionDefinition), typeDiscriminator: "DeliveryWeightBasedOptionDefinition")]
public interface IDeliveryOptionDefinition : IGraphQLObject
{
    /// <summary>
    /// The currency used for all money values in this shipping option.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; }

    /// <summary>
    /// Optional description shown to buyers.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; }

    /// <summary>
    /// The cart subtotal required for free shipping. Null if no threshold is set.
    /// </summary>
    [JsonPropertyName("freeDeliveryMinimumValue")]
    public MoneyV2? freeDeliveryMinimumValue { get; set; }

    /// <summary>
    /// A globally unique ID for this shipping option.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// Collections that any rate group in this shipping option applies to.
    /// </summary>
    [JsonPropertyName("includedCollections")]
    public CollectionConnection? includedCollections { get; set; }

    /// <summary>
    /// Origin locations that any rate group in this shipping option applies to.
    /// </summary>
    [JsonPropertyName("includedLocations")]
    public LocationConnection? includedLocations { get; set; }

    /// <summary>
    /// Whether this shipping option is active and shown to buyers.
    /// </summary>
    [JsonPropertyName("isActive")]
    public bool? isActive { get; set; }
}