#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `OrderCreateMandatePaymentUserError`.
/// </summary>
public enum OrderCreateMandatePaymentUserErrorCode
{
    ORDER_MANDATE_PAYMENT_ERROR_CODE,
}