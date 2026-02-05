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
/// The type of the resource that generated the event.
/// </summary>
public enum EventSubjectType
{
    COMPANY_LOCATION,
    COMPANY,
    CUSTOMER,
    DRAFT_ORDER,
    INVENTORY_TRANSFER,
    COLLECTION,
    PRODUCT,
    PRODUCT_VARIANT,
    ARTICLE,
    BLOG,
    COMMENT,
    PAGE,
    DISCOUNT_AUTOMATIC_BXGY,
    DISCOUNT_AUTOMATIC_NODE,
    DISCOUNT_CODE_NODE,
    DISCOUNT_NODE,
    PRICE_RULE,
    ORDER,
    UNKNOWN,
}