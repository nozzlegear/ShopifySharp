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
/// The valid tiers for the predicted spend of a customer with a shop.
/// </summary>
public enum CustomerPredictedSpendTier
{
    HIGH,
    MEDIUM,
    LOW,
}