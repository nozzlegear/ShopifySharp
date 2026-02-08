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
/// A gift card that customers use as a payment method. Stores the initial value, current balance, and expiration date.
/// You can issue gift cards to a specific
/// [`Customer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Customer)
/// or send them to a [`GiftCardRecipient`](https://shopify.dev/docs/api/admin-graphql/latest/objects/GiftCardRecipient)
/// with a personalized message. The card tracks its transaction history through [`GiftCardCreditTransaction`](https://shopify.dev/docs/api/admin-graphql/latest/objects/GiftCardCreditTransaction) and [`GiftCardDebitTransaction`](https://shopify.dev/docs/api/admin-graphql/latest/objects/GiftCardDebitTransaction)
/// records. You can create and deactivate gift cards using the [`GiftCardCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/giftCardCreate) and [`GiftCardDeactivate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/giftCardDeactivate)
/// mutations, respectively.
/// > Note: After a gift card is deactivated, it can't be used for further purchases or re-enabled.
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
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// The customer who will receive the gift card.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// The date and time at which the gift card was deactivated.
    /// </summary>
    [JsonPropertyName("deactivatedAt")]
    public DateTimeOffset? deactivatedAt { get; set; } = null;

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
    public DateTimeOffset? updatedAt { get; set; } = null;
}