#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A Shopify Payments address.
/// </summary>
public record ShopifyPaymentsAddressBasic : IGraphQLObject
{
    /// <summary>
    /// Line 1 of the address.
    /// </summary>
    [JsonPropertyName("addressLine1")]
    public string? addressLine1 { get; set; } = null;

    /// <summary>
    /// Line 2 of the address.
    /// </summary>
    [JsonPropertyName("addressLine2")]
    public string? addressLine2 { get; set; } = null;

    /// <summary>
    /// The address city.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The address country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? country { get; set; } = null;

    /// <summary>
    /// The address postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? postalCode { get; set; } = null;

    /// <summary>
    /// The address state/province/zone.
    /// </summary>
    [JsonPropertyName("zone")]
    public string? zone { get; set; } = null;
}