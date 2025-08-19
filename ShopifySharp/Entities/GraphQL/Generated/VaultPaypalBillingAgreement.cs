#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a paypal billing agreement payment instrument.
/// </summary>
public record VaultPaypalBillingAgreement : PaymentInstrument, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Whether the paypal billing agreement is inactive.
    /// </summary>
    [JsonPropertyName("inactive")]
    public bool? inactive { get; set; } = null;

    /// <summary>
    /// The paypal account name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The paypal account email address.
    /// </summary>
    [JsonPropertyName("paypalAccountEmail")]
    public string? paypalAccountEmail { get; set; } = null;
}