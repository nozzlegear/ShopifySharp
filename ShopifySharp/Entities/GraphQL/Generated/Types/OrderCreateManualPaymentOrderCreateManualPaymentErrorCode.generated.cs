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
/// Possible error codes that can be returned by `OrderCreateManualPaymentOrderCreateManualPaymentError`.
/// </summary>
public enum OrderCreateManualPaymentOrderCreateManualPaymentErrorCode
{
    ORDER_NOT_FOUND,
    AMOUNT_NOT_POSITIVE,
    GATEWAY_NOT_FOUND,
    AMOUNT_EXCEEDS_BALANCE,
    ORDER_IS_TEMPORARILY_UNAVAILABLE,
    PROCESSED_AT_INVALID,
}