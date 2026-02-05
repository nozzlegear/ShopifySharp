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
/// The address at which the fulfillment occurred. This object is intended for tax
/// purposes, as a full address is required for tax providers to accurately
/// calculate taxes. Typically this is the address of the warehouse or fulfillment
/// center. To retrieve a fulfillment location's address, use the `assignedLocation` field on the
/// [`FulfillmentOrder`](/docs/api/admin-graphql/latest/objects/FulfillmentOrder)
/// object instead.
/// </summary>
public record FulfillmentOriginAddress : IGraphQLObject
{
    /// <summary>
    /// The street address of the fulfillment location.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The second line of the address. Typically the number of the apartment, suite, or unit.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? address2 { get; set; } = null;

    /// <summary>
    /// The city in which the fulfillment location is located.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The country code of the fulfillment location.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public string? countryCode { get; set; } = null;

    /// <summary>
    /// The province code of the fulfillment location.
    /// </summary>
    [JsonPropertyName("provinceCode")]
    public string? provinceCode { get; set; } = null;

    /// <summary>
    /// The zip code of the fulfillment location.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}