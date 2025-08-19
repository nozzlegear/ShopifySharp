#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible status values of the last payment on a subscription contract.
/// </summary>
public enum SubscriptionContractLastPaymentStatus
{
    SUCCEEDED,
    FAILED,
}