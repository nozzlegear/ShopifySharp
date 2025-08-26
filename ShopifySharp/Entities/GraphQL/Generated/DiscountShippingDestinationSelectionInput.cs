#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the destinations where the free shipping discount will be applied.
/// </summary>
public record DiscountShippingDestinationSelectionInput : GraphQLInputObject<DiscountShippingDestinationSelectionInput>
{
    /// <summary>
    /// Whether the discount code applies to all countries.
    /// </summary>
    [JsonPropertyName("all")]
    public bool? all { get; set; } = null;

    /// <summary>
    /// A list of countries where the discount code will apply.
    /// </summary>
    [JsonPropertyName("countries")]
    public DiscountCountriesInput? countries { get; set; } = null;
}