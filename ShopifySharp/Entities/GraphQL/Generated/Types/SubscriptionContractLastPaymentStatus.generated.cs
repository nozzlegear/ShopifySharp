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
/// The possible status values of the last payment on a subscription contract.
/// </summary>
public enum SubscriptionContractLastPaymentStatus
{
    SUCCEEDED,
    FAILED,
}