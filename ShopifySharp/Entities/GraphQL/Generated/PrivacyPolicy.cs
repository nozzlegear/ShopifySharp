#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A shop's privacy policy settings.
/// </summary>
public record PrivacyPolicy : IGraphQLObject
{
    /// <summary>
    /// Whether the policy is auto managed.
    /// </summary>
    [JsonPropertyName("autoManaged")]
    public bool? autoManaged { get; set; } = null;

    /// <summary>
    /// Policy template supported locales.
    /// </summary>
    [JsonPropertyName("supportedLocales")]
    public ICollection<string>? supportedLocales { get; set; } = null;
}