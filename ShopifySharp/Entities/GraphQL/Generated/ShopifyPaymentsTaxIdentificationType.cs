#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of tax identification field.
/// </summary>
public enum ShopifyPaymentsTaxIdentificationType
{
    SSN_LAST4_DIGITS,
    FULL_SSN,
    EIN,
}