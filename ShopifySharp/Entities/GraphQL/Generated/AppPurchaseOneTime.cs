#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Services and features purchased once by a store.
/// </summary>
public record AppPurchaseOneTime : IGraphQLObject, IAppPurchase, INode
{
    /// <summary>
    /// The date and time when the app purchase occurred.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the app purchase.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The amount to be charged to the store for the app purchase.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; } = null;

    /// <summary>
    /// The status of the app purchase.
    /// </summary>
    [JsonPropertyName("status")]
    public AppPurchaseStatus? status { get; set; } = null;

    /// <summary>
    /// Whether the app purchase is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;
}