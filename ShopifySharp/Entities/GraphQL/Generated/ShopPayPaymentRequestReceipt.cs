#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The receipt of Shop Pay payment request session submission.
/// </summary>
public record ShopPayPaymentRequestReceipt : IGraphQLObject
{
    /// <summary>
    /// The date and time when the payment request receipt was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The order that's associated with the payment request receipt.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The shop pay payment request object.
    /// </summary>
    [JsonPropertyName("paymentRequest")]
    public ShopPayPaymentRequest? paymentRequest { get; set; } = null;

    /// <summary>
    /// The status of the payment request session submission.
    /// </summary>
    [JsonPropertyName("processingStatus")]
    public ShopPayPaymentRequestReceiptProcessingStatus? processingStatus { get; set; } = null;

    /// <summary>
    /// The source identifier provided in the `ShopPayPaymentRequestSessionCreate` mutation.
    /// </summary>
    [JsonPropertyName("sourceIdentifier")]
    public string? sourceIdentifier { get; set; } = null;

    /// <summary>
    /// The token of the receipt, initially returned by an `ShopPayPaymentRequestSessionSubmit` mutation.
    /// </summary>
    [JsonPropertyName("token")]
    public string? token { get; set; } = null;
}