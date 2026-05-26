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
/// System reason codes for cash management.
/// </summary>
public enum CashManagementSystemReasonCodeEnum
{
    FLOAT_SETUP,
    CASH_PAYOUT,
    [Obsolete("Use CashManagementDefaultReasonCodeEnum.OTHER instead.")]
    OTHER,
    AUTO_END_SESSION_LOGOUT,
    AUTO_END_SESSION_LOCATION_CHANGE,
    AUTO_START_SESSION_CHECKOUT,
}