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
/// A component option value related to a bundle line.
/// </summary>
public record ProductBundleComponentOptionSelectionValue : IGraphQLObject
{
    /// <summary>
    /// Selection status of the option.
    /// </summary>
    [JsonPropertyName("selectionStatus")]
    public ProductBundleComponentOptionSelectionStatus? selectionStatus { get; set; } = null;

    /// <summary>
    /// The value of the option.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}