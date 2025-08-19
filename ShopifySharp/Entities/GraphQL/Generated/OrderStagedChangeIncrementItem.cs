#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An addition of items to an existing line item on the order.
/// </summary>
public record OrderStagedChangeIncrementItem : OrderStagedChange, IGraphQLUnionCase, IGraphQLObject
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