#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Specifies the
/// [Urchin Traffic Module (UTM) parameters](https://en.wikipedia.org/wiki/UTM_parameters)
/// that are associated with a related marketing campaign.
/// </summary>
public record UTMInput : GraphQLInputObject<UTMInput>
{
    /// <summary>
    /// The name of the UTM campaign.
    /// </summary>
    [JsonPropertyName("campaign")]
    public string? campaign { get; set; } = null;

    /// <summary>
    /// The UTM campaign medium.
    /// </summary>
    [JsonPropertyName("medium")]
    public string? medium { get; set; } = null;

    /// <summary>
    /// The name of the website or application where the referral link exists.
    /// </summary>
    [JsonPropertyName("source")]
    public string? source { get; set; } = null;
}