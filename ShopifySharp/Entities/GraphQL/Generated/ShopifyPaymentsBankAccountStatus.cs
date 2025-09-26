#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The bank account status.
/// </summary>
public enum ShopifyPaymentsBankAccountStatus
{
    NEW,
    VALIDATED,
    VERIFIED,
    ERRORED,
}