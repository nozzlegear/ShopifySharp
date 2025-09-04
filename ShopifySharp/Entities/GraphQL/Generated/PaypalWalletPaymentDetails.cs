#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// PayPal Wallet payment details related to a transaction.
/// </summary>
public record PaypalWalletPaymentDetails : IGraphQLUnionCase, IGraphQLObject, IBasePaymentDetails
{
    /// <summary>
    /// The name of payment method used by the buyer.
    /// </summary>
    [JsonPropertyName("paymentMethodName")]
    public string? paymentMethodName { get; set; } = null;
}