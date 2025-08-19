#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible values of the last billing error on a subscription contract.
/// </summary>
public enum SubscriptionContractLastBillingErrorType
{
    PAYMENT_ERROR,
    CUSTOMER_ERROR,
    INVENTORY_ERROR,
    OTHER,
}