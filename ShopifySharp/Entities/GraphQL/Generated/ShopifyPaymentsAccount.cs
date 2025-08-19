#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Balance and payout information for a
/// [Shopify Payments](https://help.shopify.com/manual/payments/shopify-payments/getting-paid-with-shopify-payments)
/// account. Balance includes all balances for the currencies supported by the shop.
/// You can also query for a list of payouts, where each payout includes the corresponding currencyCode field.
/// </summary>
public record ShopifyPaymentsAccount : IGraphQLObject, INode
{
    /// <summary>
    /// The name of the account opener.
    /// </summary>
    [JsonPropertyName("accountOpenerName")]
    public string? accountOpenerName { get; set; } = null;

    /// <summary>
    /// Whether the Shopify Payments setup is completed.
    /// </summary>
    [JsonPropertyName("activated")]
    public bool? activated { get; set; } = null;

    /// <summary>
    /// Current balances in all currencies for the account.
    /// </summary>
    [JsonPropertyName("balance")]
    public ICollection<MoneyV2>? balance { get; set; } = null;

    /// <summary>
    /// A list of balance transactions associated with the shop.
    /// </summary>
    [JsonPropertyName("balanceTransactions")]
    public ShopifyPaymentsBalanceTransactionConnection? balanceTransactions { get; set; } = null;

    /// <summary>
    /// All bank accounts configured for the Shopify Payments account.
    /// </summary>
    [JsonPropertyName("bankAccounts")]
    public ShopifyPaymentsBankAccountConnection? bankAccounts { get; set; } = null;

    /// <summary>
    /// The statement descriptor used for charges.
    /// The statement descriptor appears on a customer's credit card or bank statement when they make a purchase.
    /// </summary>
    [JsonPropertyName("chargeStatementDescriptor")]
    [Obsolete("Use `chargeStatementDescriptors` instead.")]
    public string? chargeStatementDescriptor { get; set; } = null;

    /// <summary>
    /// The statement descriptors used for charges.
    /// These descriptors appear on a customer's credit card or bank statement when they make a purchase.
    /// </summary>
    [JsonPropertyName("chargeStatementDescriptors")]
    public IShopifyPaymentsChargeStatementDescriptor? chargeStatementDescriptors { get; set; } = null;

    /// <summary>
    /// The Shopify Payments account country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? country { get; set; } = null;

    /// <summary>
    /// The default payout currency for the Shopify Payments account.
    /// </summary>
    [JsonPropertyName("defaultCurrency")]
    public CurrencyCode? defaultCurrency { get; set; } = null;

    /// <summary>
    /// All disputes that originated from a transaction made with the Shopify Payments account.
    /// </summary>
    [JsonPropertyName("disputes")]
    public ShopifyPaymentsDisputeConnection? disputes { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether the Shopify Payments account can be onboarded.
    /// </summary>
    [JsonPropertyName("onboardable")]
    public bool? onboardable { get; set; } = null;

    /// <summary>
    /// All current and previous payouts made between the account and the bank account.
    /// </summary>
    [JsonPropertyName("payouts")]
    public ShopifyPaymentsPayoutConnection? payouts { get; set; } = null;

    /// <summary>
    /// The payout schedule for the account.
    /// </summary>
    [JsonPropertyName("payoutSchedule")]
    public ShopifyPaymentsPayoutSchedule? payoutSchedule { get; set; } = null;

    /// <summary>
    /// The descriptor used for payouts.
    /// The descriptor appears on a merchant's bank statement when they receive a payout.
    /// </summary>
    [JsonPropertyName("payoutStatementDescriptor")]
    public string? payoutStatementDescriptor { get; set; } = null;
}