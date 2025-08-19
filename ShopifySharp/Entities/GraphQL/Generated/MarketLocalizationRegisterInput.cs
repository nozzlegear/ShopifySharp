#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields and values for creating or updating a market localization.
/// </summary>
public record MarketLocalizationRegisterInput : GraphQLInputObject<MarketLocalizationRegisterInput>
{
    /// <summary>
    /// A reference to the value being localized on the resource that this market localization belongs to.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The ID of the market that the localization is specific to.
    /// </summary>
    [JsonPropertyName("marketId")]
    public string? marketId { get; set; } = null;

    /// <summary>
    /// A hash digest representation of the content being localized.
    /// </summary>
    [JsonPropertyName("marketLocalizableContentDigest")]
    public string? marketLocalizableContentDigest { get; set; } = null;

    /// <summary>
    /// The value of the market localization.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}