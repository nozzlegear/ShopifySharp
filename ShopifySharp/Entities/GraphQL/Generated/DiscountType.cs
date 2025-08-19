#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of the subscription discount.
/// </summary>
public enum DiscountType
{
    MANUAL,
    CODE_DISCOUNT,
    AUTOMATIC_DISCOUNT,
}