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
/// The checkout charge when the full amount isn't charged at checkout.
/// </summary>
public enum SellingPlanCheckoutChargeType
{
    PERCENTAGE,
    PRICE,
}