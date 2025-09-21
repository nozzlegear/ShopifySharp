#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the order's current financial status.
/// </summary>
public enum OrderDisplayFinancialStatus
{
    PENDING,
    AUTHORIZED,
    PARTIALLY_PAID,
    PARTIALLY_REFUNDED,
    VOIDED,
    PAID,
    REFUNDED,
    EXPIRED,
}