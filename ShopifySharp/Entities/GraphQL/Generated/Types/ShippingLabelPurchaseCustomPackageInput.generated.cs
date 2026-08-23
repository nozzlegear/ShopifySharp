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
/// The input fields for a custom package to use for the shipping label purchase.
/// </summary>
public record ShippingLabelPurchaseCustomPackageInput : GraphQLInputObject<ShippingLabelPurchaseCustomPackageInput>
{
    /// <summary>
    /// The outside dimensions of the shipping package.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public ObjectDimensionsInput? dimensions { get; set; } = null;

    /// <summary>
    /// The package type. Defaults to `BOX`.
    /// </summary>
    [JsonPropertyName("type")]
    public ShippingPackageType? type { get; set; } = null;

    /// <summary>
    /// The weight of the empty package.
    /// </summary>
    [JsonPropertyName("weight")]
    public WeightInput? weight { get; set; } = null;
}