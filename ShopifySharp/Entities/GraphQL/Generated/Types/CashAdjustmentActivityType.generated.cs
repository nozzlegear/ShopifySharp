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
/// The type of adjustment activity.
/// </summary>
public enum CashAdjustmentActivityType
{
    ADJUSTMENT,
    CASH_PAYOUT,
    CLOSING_ADJUSTMENT,
}