#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Interface for a gift card transaction.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(GiftCardCreditTransaction), typeDiscriminator: "GiftCardCreditTransaction")]
[JsonDerivedType(typeof(GiftCardDebitTransaction), typeDiscriminator: "GiftCardDebitTransaction")]
public interface IGiftCardTransaction : IGraphQLObject
{
    /// <summary>
    /// The amount of the transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; }

    /// <summary>
    /// The gift card that the transaction belongs to.
    /// </summary>
    [JsonPropertyName("giftCard")]
    public GiftCard? giftCard { get; set; }

    /// <summary>
    /// The unique ID for the transaction.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; }

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; }

    /// <summary>
    /// A note about the transaction.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; }

    /// <summary>
    /// The date and time when the transaction was processed.
    /// </summary>
    [JsonPropertyName("processedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? processedAt { get; set; }
}