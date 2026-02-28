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
/// A shipping option associated with order delivery that includes pricing and service information.
/// </summary>
public record ShippingRate : IGraphQLObject
{
    /// <summary>
    /// Human-readable unique identifier for this shipping rate.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The cost associated with the shipping rate.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The name of the shipping rate.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}