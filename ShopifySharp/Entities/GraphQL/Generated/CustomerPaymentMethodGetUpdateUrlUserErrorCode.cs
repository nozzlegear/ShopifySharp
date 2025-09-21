#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `CustomerPaymentMethodGetUpdateUrlUserError`.
/// </summary>
public enum CustomerPaymentMethodGetUpdateUrlUserErrorCode
{
    PAYMENT_METHOD_DOES_NOT_EXIST,
    INVALID_INSTRUMENT,
    TOO_MANY_REQUESTS,
    CUSTOMER_DOES_NOT_EXIST,
}