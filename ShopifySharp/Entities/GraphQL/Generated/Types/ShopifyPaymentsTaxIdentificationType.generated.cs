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
/// The type of tax identification field.
/// </summary>
public enum ShopifyPaymentsTaxIdentificationType
{
    SSN_LAST4_DIGITS,
    FULL_SSN,
    EIN,
}