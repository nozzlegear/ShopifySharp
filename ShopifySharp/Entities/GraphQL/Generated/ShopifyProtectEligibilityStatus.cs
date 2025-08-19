#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of an order's eligibility for protection against fraudulent chargebacks by Shopify Protect.
/// </summary>
public enum ShopifyProtectEligibilityStatus
{
    PENDING,
    ELIGIBLE,
    NOT_ELIGIBLE,
}