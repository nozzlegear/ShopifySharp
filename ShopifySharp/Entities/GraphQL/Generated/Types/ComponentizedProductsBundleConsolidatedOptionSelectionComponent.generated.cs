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
/// A component that's included in a bundle consolidated option selection.
/// </summary>
public record ComponentizedProductsBundleConsolidatedOptionSelectionComponent : IGraphQLObject
{
    /// <summary>
    /// The ID of the component's option that's included in this consolidated option selection.
    /// </summary>
    [JsonPropertyName("optionId")]
    public string? optionId { get; set; } = null;

    /// <summary>
    /// The value of the component's option value that's included in this consolidated option selection.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}