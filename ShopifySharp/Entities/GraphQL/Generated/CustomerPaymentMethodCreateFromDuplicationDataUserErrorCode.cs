#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `CustomerPaymentMethodCreateFromDuplicationDataUserError`.
/// </summary>
public enum CustomerPaymentMethodCreateFromDuplicationDataUserErrorCode
{
    TOO_MANY_REQUESTS,
    CUSTOMER_DOES_NOT_EXIST,
    INVALID_ENCRYPTED_DUPLICATION_DATA,
}