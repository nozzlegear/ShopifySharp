#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The inventory policy for a billing attempt.
/// </summary>
public enum SubscriptionBillingAttemptInventoryPolicy
{
    PRODUCT_VARIANT_INVENTORY_POLICY,
    ALLOW_OVERSELLING,
}