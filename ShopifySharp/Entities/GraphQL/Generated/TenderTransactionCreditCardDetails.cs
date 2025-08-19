#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Information about the credit card used for this transaction.
/// </summary>
public record TenderTransactionCreditCardDetails : TenderTransactionDetails, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The name of the company that issued the customer's credit card. Example: `Visa`.
    /// </summary>
    [JsonPropertyName("creditCardCompany")]
    public string? creditCardCompany { get; set; } = null;

    /// <summary>
    /// The customer's credit card number, with all digits except the last 4 redacted. Example: `•••• •••• •••• 1234`
    /// </summary>
    [JsonPropertyName("creditCardNumber")]
    public string? creditCardNumber { get; set; } = null;
}