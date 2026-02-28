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
/// The input fields for a consolidated option on a componentized product.
/// </summary>
public record ProductBundleConsolidatedOptionInput : GraphQLInputObject<ProductBundleConsolidatedOptionInput>
{
    /// <summary>
    /// The name of the consolidated option (e.g., 'Size', 'Color').
    /// </summary>
    [JsonPropertyName("optionName")]
    public string? optionName { get; set; } = null;

    /// <summary>
    /// The option selections that define how this consolidated option maps to component options.
    /// </summary>
    [JsonPropertyName("optionSelections")]
    public ICollection<ProductBundleConsolidatedOptionSelectionInput>? optionSelections { get; set; } = null;
}