#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The interval at which payouts are sent to the connected bank account.
/// </summary>
public enum ShopifyPaymentsPayoutInterval
{
    DAILY,
    WEEKLY,
    MONTHLY,
    MANUAL,
}