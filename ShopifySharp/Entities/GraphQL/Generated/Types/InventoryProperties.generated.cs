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
/// General inventory properties for the shop.
/// </summary>
public record InventoryProperties : IGraphQLObject
{
    /// <summary>
    /// All the quantity names.
    /// </summary>
    [JsonPropertyName("quantityNames")]
    public ICollection<InventoryQuantityName>? quantityNames { get; set; } = null;
}