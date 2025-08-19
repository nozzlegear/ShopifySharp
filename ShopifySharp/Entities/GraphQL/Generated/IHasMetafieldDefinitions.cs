#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Resources that metafield definitions can be applied to.
/// </summary>
public interface IHasMetafieldDefinitions : IGraphQLObject
{
    /// <summary>
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; }
}