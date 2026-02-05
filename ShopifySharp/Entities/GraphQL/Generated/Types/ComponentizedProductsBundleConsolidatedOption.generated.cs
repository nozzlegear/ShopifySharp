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
/// An option on the bundle parent product that is consolidated from multiple different components.
/// </summary>
public record ComponentizedProductsBundleConsolidatedOption : IGraphQLObject
{
    /// <summary>
    /// The name of the consolidated option.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The selections of the consolidated option.
    /// </summary>
    [JsonPropertyName("selections")]
    public ICollection<ComponentizedProductsBundleConsolidatedOptionSelection>? selections { get; set; } = null;
}