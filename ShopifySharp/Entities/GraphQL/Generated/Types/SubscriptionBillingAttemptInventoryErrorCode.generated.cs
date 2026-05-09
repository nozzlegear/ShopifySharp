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
/// Error codes for inventory-related billing attempt failures.
/// </summary>
public enum SubscriptionBillingAttemptInventoryErrorCode
{
    INSUFFICIENT_INVENTORY,
    INVENTORY_ALLOCATIONS_NOT_FOUND,
}