#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible types of a metafield's owner resource.
/// </summary>
public enum MetafieldOwnerType
{
    API_PERMISSION,
    COMPANY,
    COMPANY_LOCATION,
    PAYMENT_CUSTOMIZATION,
    VALIDATION,
    CUSTOMER,
    DELIVERY_CUSTOMIZATION,
    DRAFTORDER,
    GIFT_CARD_TRANSACTION,
    MARKET,
    CARTTRANSFORM,
    COLLECTION,
    [Obsolete("`MEDIA_IMAGE` is deprecated.")]
    MEDIA_IMAGE,
    PRODUCT,
    PRODUCTVARIANT,
    SELLING_PLAN,
    ARTICLE,
    BLOG,
    PAGE,
    FULFILLMENT_CONSTRAINT_RULE,
    ORDER_ROUTING_LOCATION_RULE,
    DISCOUNT,
    ORDER,
    LOCATION,
    SHOP,
}