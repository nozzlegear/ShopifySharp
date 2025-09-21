#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a custom shipping package used to pack shipment.
/// </summary>
public record CustomShippingPackageInput : GraphQLInputObject<CustomShippingPackageInput>
{
    /// <summary>
    /// The default package is the one used to calculate shipping costs on checkout.
    /// </summary>
    [JsonPropertyName("default")]
    public bool? @default { get; set; } = null;

    /// <summary>
    /// Outside dimensions of the empty shipping package.
    /// </summary>
    [JsonPropertyName("dimensions")]
    public ObjectDimensionsInput? dimensions { get; set; } = null;

    /// <summary>
    /// Descriptive name for the package.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Type of package.
    /// </summary>
    [JsonPropertyName("type")]
    public ShippingPackageType? type { get; set; } = null;

    /// <summary>
    /// Weight of the empty shipping package.
    /// </summary>
    [JsonPropertyName("weight")]
    public WeightInput? weight { get; set; } = null;
}