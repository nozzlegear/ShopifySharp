#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of a customer's payment for an order.
/// </summary>
public record OrderPaymentStatus : IGraphQLObject
{
    /// <summary>
    /// A message describing an error during the asynchronous processing of a payment.
    /// </summary>
    [JsonPropertyName("errorMessage")]
    public string? errorMessage { get; set; } = null;

    /// <summary>
    /// The ID of the payment, initially returned by an `orderCreateMandatePayment` or `orderCreatePayment` mutation.
    /// </summary>
    [JsonPropertyName("paymentReferenceId")]
    public string? paymentReferenceId { get; set; } = null;

    /// <summary>
    /// The status of the payment.
    /// </summary>
    [JsonPropertyName("status")]
    public OrderPaymentStatusResult? status { get; set; } = null;

    /// <summary>
    /// The transaction associated with the payment.
    /// </summary>
    [JsonPropertyName("transactions")]
    public ICollection<OrderTransaction>? transactions { get; set; } = null;

    /// <summary>
    /// A translated message describing an error during the asynchronous processing of a payment.
    /// </summary>
    [JsonPropertyName("translatedErrorMessage")]
    public string? translatedErrorMessage { get; set; } = null;
}