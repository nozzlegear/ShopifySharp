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
/// The possible values of the last billing error on a subscription contract.
/// </summary>
public enum SubscriptionContractLastBillingErrorType
{
    PAYMENT_ERROR,
    CUSTOMER_ERROR,
    INVENTORY_ERROR,
    OTHER,
}