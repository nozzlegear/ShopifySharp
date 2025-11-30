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
/// The [discount class](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
/// that's used to control how discounts can be combined.
/// </summary>
public enum MerchandiseDiscountClass
{
    PRODUCT,
    ORDER,
}