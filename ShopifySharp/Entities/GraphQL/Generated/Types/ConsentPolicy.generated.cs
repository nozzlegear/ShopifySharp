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
/// A consent policy describes the level of consent that the merchant requires from the user before actually
/// collecting and processing the data.
/// </summary>
public record ConsentPolicy : IGraphQLObject, INode
{
    /// <summary>
    /// Whether consent is required for the region.
    /// </summary>
    [JsonPropertyName("consentRequired")]
    public bool? consentRequired { get; set; } = null;

    /// <summary>
    /// The `ISO 3166` country code for which the policy applies.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public PrivacyCountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// Whether data sale opt-out is required for the region.
    /// </summary>
    [JsonPropertyName("dataSaleOptOutRequired")]
    public bool? dataSaleOptOutRequired { get; set; } = null;

    /// <summary>
    /// The global ID of the consent policy. IDs prefixed with `SD-` are system default policies.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The `ISO 3166` region code for which the policy applies.
    /// </summary>
    [JsonPropertyName("regionCode")]
    public string? regionCode { get; set; } = null;

    /// <summary>
    /// The global ID of the shop that owns the policy.
    /// </summary>
    [JsonPropertyName("shopId")]
    public string? shopId { get; set; } = null;
}