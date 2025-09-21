#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The different methods that a refund amount can be allocated to.
/// </summary>
public enum RefundMethodAllocation
{
    ORIGINAL_PAYMENT_METHODS,
    STORE_CREDIT,
}