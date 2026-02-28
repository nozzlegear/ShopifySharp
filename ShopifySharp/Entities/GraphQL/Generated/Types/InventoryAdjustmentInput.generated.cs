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
/// The input fields required to adjust the available quantity of a product variant at a location.
/// </summary>
public record InventoryAdjustmentInput : GraphQLInputObject<InventoryAdjustmentInput>
{
    /// <summary>
    /// The adjustment of the available quantity at the location. If the value is
    /// `null`, then the product variant is no longer stocked at the location.
    /// </summary>
    [JsonPropertyName("adjustment")]
    public int? adjustment { get; set; } = null;

    /// <summary>
    /// The quantity to compare against before applying the delta.
    /// </summary>
    [JsonPropertyName("changeFromQuantity")]
    public int? changeFromQuantity { get; set; } = null;

    /// <summary>
    /// The ID of the location where the available quantity should be adjusted.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;
}