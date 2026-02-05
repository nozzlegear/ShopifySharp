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
/// The input fields for mapping a consolidated option to a specific component option.
/// </summary>
public record ProductBundleConsolidatedOptionComponentInput : GraphQLInputObject<ProductBundleConsolidatedOptionComponentInput>
{
    /// <summary>
    /// The ID of the component option that this consolidated option maps to.
    /// If null, this selection targets the component's quantity option with the given name.
    /// </summary>
    [JsonPropertyName("componentOptionId")]
    public string? componentOptionId { get; set; } = null;

    /// <summary>
    /// The value to use for the component option (e.g., 'Small', 'Red').
    /// </summary>
    [JsonPropertyName("componentOptionValue")]
    public string? componentOptionValue { get; set; } = null;
}