#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An addition of items to an existing line item on the order.
/// </summary>
public record OrderStagedChangeIncrementItem : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The number of items added.
    /// </summary>
    [JsonPropertyName("delta")]
    public int? delta { get; set; } = null;

    /// <summary>
    /// The original line item.
    /// </summary>
    [JsonPropertyName("lineItem")]
    public LineItem? lineItem { get; set; } = null;
}