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
/// An removal of items from an existing line item on the order.
/// </summary>
public record OrderStagedChangeDecrementItem : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The number of items removed.
    /// </summary>
    [JsonPropertyName("delta")]
    public int? delta { get; set; } = null;

    /// <summary>
    /// The original line item.
    /// </summary>
    [JsonPropertyName("lineItem")]
    public LineItem? lineItem { get; set; } = null;

    /// <summary>
    /// The intention to restock the removed items.
    /// </summary>
    [JsonPropertyName("restock")]
    public bool? restock { get; set; } = null;
}