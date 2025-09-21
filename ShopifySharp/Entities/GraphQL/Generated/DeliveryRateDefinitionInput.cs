#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a rate definition.
/// </summary>
public record DeliveryRateDefinitionInput : GraphQLInputObject<DeliveryRateDefinitionInput>
{
    /// <summary>
    /// A globally-unique ID of the rate definition.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The price of the rate definition.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyInput? price { get; set; } = null;
}