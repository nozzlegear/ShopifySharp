#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `PaymentTermsCreateUserError`.
/// </summary>
public enum PaymentTermsCreateUserErrorCode
{
    PAYMENT_TERMS_CREATION_UNSUCCESSFUL,
}