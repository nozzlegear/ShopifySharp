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
/// A menu item type.
/// </summary>
public enum MenuItemType
{
    FRONTPAGE,
    COLLECTION,
    COLLECTIONS,
    PRODUCT,
    CATALOG,
    PAGE,
    BLOG,
    ARTICLE,
    SEARCH,
    SHOP_POLICY,
    HTTP,
    METAOBJECT,
    CUSTOMER_ACCOUNT_PAGE,
}