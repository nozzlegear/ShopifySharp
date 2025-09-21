#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A MerchantCategoryCode (MCC) is a four-digit number listed in ISO 18245 for
/// retail financial services and used to classify the business by the type of goods
/// or services it provides.
/// </summary>
public record ShopifyPaymentsMerchantCategoryCode : IGraphQLObject
{
    /// <summary>
    /// The category of the MCC.
    /// </summary>
    [JsonPropertyName("category")]
    public string? category { get; set; } = null;

    /// <summary>
    /// The category label of the MCC.
    /// </summary>
    [JsonPropertyName("categoryLabel")]
    public string? categoryLabel { get; set; } = null;

    /// <summary>
    /// A four-digit number listed in ISO 18245.
    /// </summary>
    [JsonPropertyName("code")]
    public int? code { get; set; } = null;

    /// <summary>
    /// The ID of the MCC.
    /// </summary>
    [JsonPropertyName("id")]
    public int? id { get; set; } = null;

    /// <summary>
    /// The subcategory label of the MCC.
    /// </summary>
    [JsonPropertyName("subcategoryLabel")]
    public string? subcategoryLabel { get; set; } = null;
}