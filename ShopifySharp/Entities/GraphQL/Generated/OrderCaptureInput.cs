#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the authorized transaction to capture and the total amount to capture from it.
/// </summary>
public record OrderCaptureInput : GraphQLInputObject<OrderCaptureInput>
{
    /// <summary>
    /// The amount to capture. The capture amount can't be greater than the amount of the authorized transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The currency (in ISO format) that's used to capture the order. This must be
    /// the presentment currency (the currency used by the customer) and is a required
    /// field for orders where the currency and presentment currency differ.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;

    /// <summary>
    /// Indicates whether this is to be the final capture for the order transaction. Only applies to
    /// Shopify Payments authorizations which are multi-capturable. If true, any uncaptured amount from the
    /// authorization will be voided after the capture is completed. If false, the authorization will remain open
    /// for future captures.
    /// For multi-capturable authorizations, this defaults to false if not provided. This field has no effect on
    /// authorizations which aren't multi-capturable (can only be captured once), or on other types of
    /// transactions.
    /// </summary>
    [JsonPropertyName("finalCapture")]
    public bool? finalCapture { get; set; } = null;

    /// <summary>
    /// The ID of the order to capture.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The ID of the authorized transaction to capture.
    /// </summary>
    [JsonPropertyName("parentTransactionId")]
    public string? parentTransactionId { get; set; } = null;
}