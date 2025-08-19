#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the destination where the items should be sent upon fulfillment.
/// </summary>
public record FulfillmentOrderDestination : IGraphQLObject, INode
{
    /// <summary>
    /// The first line of the address of the destination.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The second line of the address of the destination.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? address2 { get; set; } = null;

    /// <summary>
    /// The city of the destination.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The company of the destination.
    /// </summary>
    [JsonPropertyName("company")]
    public string? company { get; set; } = null;

    /// <summary>
    /// The two-letter country code of the destination.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The email of the customer at the destination.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The first name of the customer at the destination.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The last name of the customer at the destination.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The location designated for the pick-up of the fulfillment order.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The phone number of the customer at the destination.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The province of the destination.
    /// </summary>
    [JsonPropertyName("province")]
    public string? province { get; set; } = null;

    /// <summary>
    /// The ZIP code of the destination.
    /// </summary>
    [JsonPropertyName("zip")]
    public string? zip { get; set; } = null;
}