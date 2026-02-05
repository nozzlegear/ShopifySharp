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
/// The valid discount types that can be applied to a draft order.
/// </summary>
public enum DraftOrderAppliedDiscountType
{
    FIXED_AMOUNT,
    PERCENTAGE,
}