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
/// An option selection for a bundle consolidated option.
/// </summary>
public record ComponentizedProductsBundleConsolidatedOptionSelection : IGraphQLObject
{
    /// <summary>
    /// The component values that are included in the consolidated option selection.
    /// </summary>
    [JsonPropertyName("components")]
    public ICollection<ComponentizedProductsBundleConsolidatedOptionSelectionComponent>? components { get; set; } = null;

    /// <summary>
    /// The value of the consolidated option on the bundle parent.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}