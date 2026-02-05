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
/// Discrepancy reasons for order adjustments.
/// </summary>
public enum OrderAdjustmentInputDiscrepancyReason
{
    RESTOCK,
    DAMAGE,
    CUSTOMER,
    OTHER,
}