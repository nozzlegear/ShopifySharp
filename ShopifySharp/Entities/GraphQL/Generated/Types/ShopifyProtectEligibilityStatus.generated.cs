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
/// The status of an order's eligibility for protection against fraudulent chargebacks by Shopify Protect.
/// </summary>
public enum ShopifyProtectEligibilityStatus
{
    PENDING,
    ELIGIBLE,
    NOT_ELIGIBLE,
}