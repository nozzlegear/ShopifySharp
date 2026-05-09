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
/// Default reason codes for cash management.
/// </summary>
public enum CashManagementDefaultReasonCodeEnum
{
    CASH_PICKUP,
    CASH_COUNT,
    CHANGE_CORRECTION,
    PETTY_CASH,
    TIP_PAYOUT,
    CASH_PAYOUT,
    AUTO_END_SESSION_LOGOUT,
    AUTO_END_SESSION_LOCATION_CHANGE,
    AUTO_START_SESSION_CHECKOUT,
}