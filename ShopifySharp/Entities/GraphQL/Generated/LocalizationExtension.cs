#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the value captured by a localization extension. Localization
/// extensions are additional fields required by certain countries on international
/// orders. For example, some countries require additional fields for customs
/// information or tax identification numbers.
/// </summary>
public record LocalizationExtension : IGraphQLObject
{
    /// <summary>
    /// Country ISO 3166-1 alpha-2 code.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;

    /// <summary>
    /// The localized extension keys that are allowed.
    /// </summary>
    [JsonPropertyName("key")]
    public LocalizationExtensionKey? key { get; set; } = null;

    /// <summary>
    /// The purpose of this localization extension.
    /// </summary>
    [JsonPropertyName("purpose")]
    public LocalizationExtensionPurpose? purpose { get; set; } = null;

    /// <summary>
    /// The localized extension title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The value of the field.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}