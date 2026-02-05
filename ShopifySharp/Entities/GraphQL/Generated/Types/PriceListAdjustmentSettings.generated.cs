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
/// Represents the settings of price list adjustments.
/// </summary>
public record PriceListAdjustmentSettings : IGraphQLObject
{
    /// <summary>
    /// The type of price list adjustment setting for compare at price.
    /// </summary>
    [JsonPropertyName("compareAtMode")]
    public PriceListCompareAtMode? compareAtMode { get; set; } = null;
}