#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The valid discount types that can be applied to a draft order.
/// </summary>
public enum DraftOrderAppliedDiscountType
{
    FIXED_AMOUNT,
    PERCENTAGE,
}