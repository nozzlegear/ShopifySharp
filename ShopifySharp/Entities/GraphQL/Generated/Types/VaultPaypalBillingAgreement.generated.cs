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
/// Represents a paypal billing agreement payment instrument.
/// </summary>
public record VaultPaypalBillingAgreement : IGraphQLUnionCase, IGraphQLObject
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