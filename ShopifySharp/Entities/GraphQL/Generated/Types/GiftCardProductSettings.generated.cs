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
/// The gift card configuration settings for a
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product),
/// including the
/// [`issuanceCurrency`](https://shopify.dev/docs/api/admin-graphql/latest/objects/GiftCardProductSettings#field-GiftCardProductSettings.fields.issuanceCurrency)
/// and whether the gift card can be redeemed across currencies via
/// [`crossCurrencyRedeemable`](https://shopify.dev/docs/api/admin-graphql/latest/objects/GiftCardProductSettings#field-GiftCardProductSettings.fields.crossCurrencyRedeemable).
/// Configure these settings when creating a gift card product with the
/// [`giftCardProductSet`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/giftCardProductSet)
/// mutation.
/// </summary>
public record GiftCardProductSettings : IGraphQLObject
{
    /// <summary>
    /// Whether the gift card can be redeemed in currencies other than the issuance currency.
    /// </summary>
    [JsonPropertyName("crossCurrencyRedeemable")]
    public bool? crossCurrencyRedeemable { get; set; } = null;

    /// <summary>
    /// The currency in which the gift card fulfilled by this product is issued.
    /// When this field isn't set the gift card will be issued in the shop's currency,
    /// the return value of this field will be `null`.
    /// When this field is set the gift card product can only be purchased in the
    /// issuance currency. A checkout violation will prevent purchases if the checkout
    /// currency doesn't match the issuance currency.
    /// Extra care should be taken to only publish a gift card product with an
    /// issuance currency in markets where that currency can be guaranteed.
    /// </summary>
    [JsonPropertyName("issuanceCurrency")]
    public CurrencyCode? issuanceCurrency { get; set; } = null;
}