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
/// The input fields for a consolidated option selection that maps to component options.
/// </summary>
public record ProductBundleConsolidatedOptionSelectionInput : GraphQLInputObject<ProductBundleConsolidatedOptionSelectionInput>
{
    /// <summary>
    /// The component mappings that define how this option value maps to specific component options.
    /// </summary>
    [JsonPropertyName("components")]
    public ICollection<ProductBundleConsolidatedOptionComponentInput>? components { get; set; } = null;

    /// <summary>
    /// The value for this consolidated option selection (e.g., 'Small', 'Medium', 'Large').
    /// </summary>
    [JsonPropertyName("optionValue")]
    public string? optionValue { get; set; } = null;
}