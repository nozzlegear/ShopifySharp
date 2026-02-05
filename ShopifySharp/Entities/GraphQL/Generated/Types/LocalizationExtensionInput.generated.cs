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
/// The input fields for a LocalizationExtensionInput.
/// </summary>
public record LocalizationExtensionInput : GraphQLInputObject<LocalizationExtensionInput>
{
    /// <summary>
    /// The key for the localization extension.
    /// </summary>
    [JsonPropertyName("key")]
    public LocalizationExtensionKey? key { get; set; } = null;

    /// <summary>
    /// The localization extension value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}