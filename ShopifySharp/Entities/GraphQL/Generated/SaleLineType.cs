#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible line types for a sale record. One of the possible order line types
/// for a sale is an adjustment. Sales adjustments occur when a refund is issued for
/// a line item that is either more or less than the total value of the line item.
/// Examples are restocking fees and goodwill payments. When this happens, Shopify
/// produces a sales agreement with sale records for each line item that is returned
/// or refunded and an additional sale record for the adjustment (for example, a
/// restocking fee). The sales records for the returned or refunded items represent
/// the reversal of the original line item sale value. The additional adjustment
/// sale record represents the difference between the original total value of all
/// line items that were refunded, and the actual amount refunded.
/// </summary>
public enum SaleLineType
{
    PRODUCT,
    TIP,
    GIFT_CARD,
    SHIPPING,
    DUTY,
    ADDITIONAL_FEE,
    FEE,
    UNKNOWN,
    ADJUSTMENT,
}