#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The status of payments associated with the order. Can only be set when the order is created.
/// </summary>
public enum OrderCreateFinancialStatus
{
    PENDING,
    AUTHORIZED,
    PARTIALLY_PAID,
    PAID,
    PARTIALLY_REFUNDED,
    REFUNDED,
    VOIDED,
    EXPIRED,
}