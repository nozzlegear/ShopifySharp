#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The checkout charge when the full amount isn't charged at checkout.
/// </summary>
public enum SellingPlanCheckoutChargeType
{
    PERCENTAGE,
    PRICE,
}