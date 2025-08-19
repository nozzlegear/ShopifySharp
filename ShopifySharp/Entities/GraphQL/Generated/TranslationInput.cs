#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields and values for creating or updating a translation.
/// </summary>
public record TranslationInput : GraphQLInputObject<TranslationInput>
{
    /// <summary>
    /// On the resource that this translation belongs to, the reference to the value being translated.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// ISO code of the locale being translated into. Only locales returned in `shopLocales` are valid.
    /// </summary>
    [JsonPropertyName("locale")]
    public string? locale { get; set; } = null;

    /// <summary>
    /// The ID of the market that the translation is specific to. Not specifying this
    /// field means that the translation will be available in all markets.
    /// </summary>
    [JsonPropertyName("marketId")]
    public string? marketId { get; set; } = null;

    /// <summary>
    /// Hash digest representation of the content being translated.
    /// </summary>
    [JsonPropertyName("translatableContentDigest")]
    public string? translatableContentDigest { get; set; } = null;

    /// <summary>
    /// The value of the translation.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}