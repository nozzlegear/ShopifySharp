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
/// The approval status of the app purchase.
/// The merchant is charged for the purchase immediately after approval, and the status changes to `active`.
/// If the payment fails, then the app purchase remains `pending`.
/// Purchases start as `pending` and can change to: `active`, `declined`, `expired`. After a purchase changes, it
/// remains in that final state.
/// </summary>
public enum AppPurchaseStatus
{
    [Obsolete("When a merchant accepts an app purchase, the status immediately changes from `pending` to `active`.")]
    ACCEPTED,
    ACTIVE,
    DECLINED,
    EXPIRED,
    PENDING,
}