#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Services and features purchased once by the store.
/// </summary>
public interface IAppPurchase : IGraphQLObject
{
    /// <summary>
    /// The date and time when the app purchase occurred.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; }

    /// <summary>
    /// The name of the app purchase.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; }

    /// <summary>
    /// The amount to be charged to the store for the app purchase.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyV2? price { get; set; }

    /// <summary>
    /// The status of the app purchase.
    /// </summary>
    [JsonPropertyName("status")]
    public AppPurchaseStatus? status { get; set; }

    /// <summary>
    /// Whether the app purchase is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; }
}