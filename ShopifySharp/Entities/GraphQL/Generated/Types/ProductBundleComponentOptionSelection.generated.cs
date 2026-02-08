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
/// A relationship between a component option and a parent option.
/// </summary>
public record ProductBundleComponentOptionSelection : IGraphQLObject
{
    /// <summary>
    /// The option that existed on the component product prior to the fixed bundle creation.
    /// </summary>
    [JsonPropertyName("componentOption")]
    public ProductOption? componentOption { get; set; } = null;

    /// <summary>
    /// The option that was created on the parent product.
    /// </summary>
    [JsonPropertyName("parentOption")]
    public ProductOption? parentOption { get; set; } = null;

    /// <summary>
    /// The component option values that are actively selected for this relationship.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<ProductBundleComponentOptionSelectionValue>? values { get; set; } = null;
}