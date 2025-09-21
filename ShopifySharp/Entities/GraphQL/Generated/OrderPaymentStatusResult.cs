#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The type of a payment status.
/// </summary>
public enum OrderPaymentStatusResult
{
    SUCCESS,
    AUTHORIZED,
    VOIDED,
    REFUNDED,
    CAPTURED,
    PURCHASED,
    ERROR,
    PROCESSING,
    REDIRECT_REQUIRED,
    RETRYABLE,
    UNKNOWN,
    INITIATED,
    PENDING,
}