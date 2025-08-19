#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `PaymentTermsUpdateUserError`.
/// </summary>
public enum PaymentTermsUpdateUserErrorCode
{
    PAYMENT_TERMS_UPDATE_UNSUCCESSFUL,
}