#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The market localizable content of a resource's field.
/// </summary>
public record MarketLocalizableContent : IGraphQLObject
{
    /// <summary>
    /// The hash digest representation of the content value.
    /// </summary>
    [JsonPropertyName("digest")]
    public string? digest { get; set; } = null;

    /// <summary>
    /// The resource field that's being localized.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The content value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}