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
/// Specifies the type of resources that are translatable.
/// </summary>
public enum TranslatableResourceType
{
    ARTICLE,
    ARTICLE_IMAGE,
    BLOG,
    COLLECTION,
    COLLECTION_IMAGE,
    DELIVERY_METHOD_DEFINITION,
    EMAIL_TEMPLATE,
    FILTER,
    LINK,
    MEDIA_IMAGE,
    MENU,
    METAFIELD,
    METAOBJECT,
    ONLINE_STORE_THEME,
    ONLINE_STORE_THEME_APP_EMBED,
    ONLINE_STORE_THEME_JSON_TEMPLATE,
    ONLINE_STORE_THEME_LOCALE_CONTENT,
    ONLINE_STORE_THEME_SECTION_GROUP,
    ONLINE_STORE_THEME_SETTINGS_CATEGORY,
    ONLINE_STORE_THEME_SETTINGS_DATA_SECTIONS,
    PACKING_SLIP_TEMPLATE,
    PAGE,
    PAYMENT_GATEWAY,
    PRODUCT,
    PRODUCT_OPTION,
    PRODUCT_OPTION_VALUE,
    SELLING_PLAN,
    SELLING_PLAN_GROUP,
    SHOP,
    SHOP_POLICY,
}