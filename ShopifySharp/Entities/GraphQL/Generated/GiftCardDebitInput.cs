#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a gift card debit transaction.
/// </summary>
public record GiftCardDebitInput : GraphQLInputObject<GiftCardDebitInput>
{
    /// <summary>
    /// The amount to debit the gift card.
    /// </summary>
    [JsonPropertyName("debitAmount")]
    public MoneyInput? debitAmount { get; set; } = null;

    /// <summary>
    /// A note about the debit.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The date and time the debit was processed. Defaults to current date and time.
    /// </summary>
    [JsonPropertyName("processedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? processedAt { get; set; } = null;
}