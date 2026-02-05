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
/// The input fields for updating the price of a parent product variant.
/// </summary>
public record PriceInput : GraphQLInputObject<PriceInput>
{
    /// <summary>
    /// The specific type of calculation done to determine the price of the parent variant.
    /// The price is calculated during Bundle creation. Updating a component variant won't recalculate the price.
    /// </summary>
    [JsonPropertyName("calculation")]
    public PriceCalculationType? calculation { get; set; } = null;

    /// <summary>
    /// The price of the parent product variant. This will be be used if calcualtion is set to 'FIXED'.
    /// </summary>
    [JsonPropertyName("price")]
    public decimal? price { get; set; } = null;
}