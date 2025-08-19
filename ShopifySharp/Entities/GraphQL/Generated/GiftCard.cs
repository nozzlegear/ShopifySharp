#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an issued gift card.
/// </summary>
public record GiftCard : IGraphQLObject, INode
{
    /// <summary>
    /// The gift card's remaining balance.
    /// </summary>
    [JsonPropertyName("balance")]
    public MoneyV2? balance { get; set; } = null;

    /// <summary>
    /// The date and time at which the gift card was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The customer who will receive the gift card.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// The date and time at which the gift card was deactivated.
    /// </summary>
    [JsonPropertyName("deactivatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? deactivatedAt { get; set; } = null;

    /// <summary>
    /// Whether the gift card is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// The date at which the gift card will expire.
    /// </summary>
    [JsonPropertyName("expiresOn")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateOnly? expiresOn { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The initial value of the gift card.
    /// </summary>
    [JsonPropertyName("initialValue")]
    public MoneyV2? initialValue { get; set; } = null;

    /// <summary>
    /// The final four characters of the gift card code.
    /// </summary>
    [JsonPropertyName("lastCharacters")]
    public string? lastCharacters { get; set; } = null;

    /// <summary>
    /// The gift card code. Everything but the final four characters is masked.
    /// </summary>
    [JsonPropertyName("maskedCode")]
    public string? maskedCode { get; set; } = null;

    /// <summary>
    /// The note associated with the gift card, which isn't visible to the customer.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The order associated with the gift card. This value is `null` if the gift card was issued manually.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The recipient who will receive the gift card.
    /// </summary>
    [JsonPropertyName("recipientAttributes")]
    public GiftCardRecipient? recipientAttributes { get; set; } = null;

    /// <summary>
    /// The theme template used to render the gift card online.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;

    /// <summary>
    /// The transaction history of the gift card.
    /// </summary>
    [JsonPropertyName("transactions")]
    public GiftCardTransactionConnection? transactions { get; set; } = null;

    /// <summary>
    /// The date and time at which the gift card was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;
}