#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Local payment methods payment details related to a transaction.
/// </summary>
public record LocalPaymentMethodsPaymentDetails : IGraphQLUnionCase, IGraphQLObject, IBasePaymentDetails
{
    /// <summary>
    /// The descriptor by the payment provider. Only available for Amazon Pay and Buy with Prime.
    /// </summary>
    [JsonPropertyName("paymentDescriptor")]
    public string? paymentDescriptor { get; set; } = null;

    /// <summary>
    /// The name of payment method used by the buyer.
    /// </summary>
    [JsonPropertyName("paymentMethodName")]
    public string? paymentMethodName { get; set; } = null;
}