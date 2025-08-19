#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `giftCardCredit` mutation.
/// </summary>
public record GiftCardCreditPayload : IGraphQLObject
{
    /// <summary>
    /// The gift card credit transaction that was created.
    /// </summary>
    [JsonPropertyName("giftCardCreditTransaction")]
    public GiftCardCreditTransaction? giftCardCreditTransaction { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<GiftCardTransactionUserError>? userErrors { get; set; } = null;
}