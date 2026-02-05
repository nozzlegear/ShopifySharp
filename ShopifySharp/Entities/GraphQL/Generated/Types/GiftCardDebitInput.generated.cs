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
    public DateTimeOffset? processedAt { get; set; } = null;
}