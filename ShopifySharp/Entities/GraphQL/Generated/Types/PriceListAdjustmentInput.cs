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
/// The input fields to set a price list adjustment.
/// </summary>
public record PriceListAdjustmentInput : GraphQLInputObject<PriceListAdjustmentInput>
{
    /// <summary>
    /// The type of price adjustment, such as percentage increase or decrease.
    /// </summary>
    [JsonPropertyName("type")]
    public PriceListAdjustmentType? type { get; set; } = null;

    /// <summary>
    /// The value of the price adjustment as specified by the `type`.
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? @value { get; set; } = null;
}