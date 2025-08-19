#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a gift card credit transaction.
/// </summary>
public record GiftCardCreditInput : GraphQLInputObject<GiftCardCreditInput>
{
    /// <summary>
    /// The amount to credit the gift card.
    /// </summary>
    [JsonPropertyName("creditAmount")]
    public MoneyInput? creditAmount { get; set; } = null;

    /// <summary>
    /// A note about the credit.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The date and time the credit was processed. Defaults to current date and time.
    /// </summary>
    [JsonPropertyName("processedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? processedAt { get; set; } = null;
}