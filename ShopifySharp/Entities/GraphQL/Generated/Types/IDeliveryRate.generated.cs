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
/// A shipping rate with a price and optional transit time.
/// Rates define the price charged to buyers for a shipping option.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DeliveryFlatRate), typeDiscriminator: "DeliveryFlatRate")]
[JsonDerivedType(typeof(DeliveryValueBasedRate), typeDiscriminator: "DeliveryValueBasedRate")]
[JsonDerivedType(typeof(DeliveryWeightBasedRate), typeDiscriminator: "DeliveryWeightBasedRate")]
public interface IDeliveryRate : IGraphQLObject
{
    /// <summary>
    /// The price charged for this rate.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; }

    /// <summary>
    /// The maximum transit time estimate in seconds.
    /// </summary>
    [JsonPropertyName("transitTimeMaxSeconds")]
    public int? transitTimeMaxSeconds { get; set; }

    /// <summary>
    /// The minimum transit time estimate in seconds.
    /// </summary>
    [JsonPropertyName("transitTimeMinSeconds")]
    public int? transitTimeMinSeconds { get; set; }
}