#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a contact field for a Shop Pay payment request.
/// </summary>
public record ShopPayPaymentRequestContactField : IGraphQLObject
{
    /// <summary>
    /// The first address line of the contact field.
    /// </summary>
    [JsonPropertyName("address1")]
    public string? address1 { get; set; } = null;

    /// <summary>
    /// The second address line of the contact field.
    /// </summary>
    [JsonPropertyName("address2")]
    public string? address2 { get; set; } = null;

    /// <summary>
    /// The city of the contact field.
    /// </summary>
    [JsonPropertyName("city")]
    public string? city { get; set; } = null;

    /// <summary>
    /// The company name of the contact field.
    /// </summary>
    [JsonPropertyName("companyName")]
    public string? companyName { get; set; } = null;

    /// <summary>
    /// The country of the contact field.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public string? countryCode { get; set; } = null;

    /// <summary>
    /// The email of the contact field.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The first name of the contact field.
    /// </summary>
    [JsonPropertyName("firstName")]
    public string? firstName { get; set; } = null;

    /// <summary>
    /// The last name of the contact field.
    /// </summary>
    [JsonPropertyName("lastName")]
    public string? lastName { get; set; } = null;

    /// <summary>
    /// The phone number of the contact field.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The postal code of the contact field.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? postalCode { get; set; } = null;

    /// <summary>
    /// The province of the contact field.
    /// </summary>
    [JsonPropertyName("provinceCode")]
    public string? provinceCode { get; set; } = null;
}