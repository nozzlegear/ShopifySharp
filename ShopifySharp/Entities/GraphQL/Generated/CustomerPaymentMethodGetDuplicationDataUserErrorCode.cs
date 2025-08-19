#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `CustomerPaymentMethodGetDuplicationDataUserError`.
/// </summary>
public enum CustomerPaymentMethodGetDuplicationDataUserErrorCode
{
    PAYMENT_METHOD_DOES_NOT_EXIST,
    INVALID_INSTRUMENT,
    TOO_MANY_REQUESTS,
    CUSTOMER_DOES_NOT_EXIST,
    SAME_SHOP,
    INVALID_ORGANIZATION_SHOP,
}