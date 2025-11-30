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
/// The product component information.
/// </summary>
public record ProductComponentType : IGraphQLObject
{
    /// <summary>
    /// The list of products' variants that are components.
    /// </summary>
    [JsonPropertyName("componentVariants")]
    public ProductVariantConnection? componentVariants { get; set; } = null;

    /// <summary>
    /// The number of component variants for the product component.
    /// </summary>
    [JsonPropertyName("componentVariantsCount")]
    public Count? componentVariantsCount { get; set; } = null;

    /// <summary>
    /// The list of products' variants that are not components.
    /// </summary>
    [JsonPropertyName("nonComponentVariants")]
    public ProductVariantConnection? nonComponentVariants { get; set; } = null;

    /// <summary>
    /// The number of non_components variants for the product component.
    /// </summary>
    [JsonPropertyName("nonComponentVariantsCount")]
    public Count? nonComponentVariantsCount { get; set; } = null;

    /// <summary>
    /// The product that's a component.
    /// </summary>
    [JsonPropertyName("product")]
    public Product? product { get; set; } = null;
}