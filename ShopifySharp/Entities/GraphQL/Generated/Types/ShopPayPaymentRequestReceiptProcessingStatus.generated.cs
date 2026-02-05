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
/// The processing status of a Shop Pay payment request.
/// Represents the different states a payment request can be in during its lifecycle,
/// from initial creation through to completion or failure.
/// </summary>
public record ShopPayPaymentRequestReceiptProcessingStatus : IGraphQLObject
{
    /// <summary>
    /// A standardized error code, independent of the payment provider.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public ShopPayPaymentRequestReceiptProcessingStatusErrorCode? errorCode { get; set; } = null;

    /// <summary>
    /// The message of the payment request receipt.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;

    /// <summary>
    /// The state of the payment request receipt.
    /// </summary>
    [JsonPropertyName("state")]
    public ShopPayPaymentRequestReceiptProcessingStatusState? state { get; set; } = null;
}