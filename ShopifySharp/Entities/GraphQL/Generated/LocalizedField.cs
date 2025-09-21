#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the value captured by a localized field. Localized fields are
/// additional fields required by certain countries on international orders. For
/// example, some countries require additional fields for customs information or tax
/// identification numbers.
/// </summary>
public record LocalizedField : IGraphQLObject
{
    /// <summary>
    /// Country ISO 3166-1 alpha-2 code.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The localized field keys that are allowed.
    /// </summary>
    [JsonPropertyName("key")]
    public LocalizedFieldKey? key { get; set; } = null;

    /// <summary>
    /// The purpose of this localized field.
    /// </summary>
    [JsonPropertyName("purpose")]
    public LocalizedFieldPurpose? purpose { get; set; } = null;

    /// <summary>
    /// The localized field title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The value of the field.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}