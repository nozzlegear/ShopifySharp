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