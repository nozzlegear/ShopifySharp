#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The details about the app extension that's providing the
/// [discount type](https://help.shopify.com/manual/discounts/discount-types).
/// This information includes the app extension's name and
/// [client ID](https://shopify.dev/docs/apps/build/authentication-authorization/client-secrets),
/// [App Bridge configuration](https://shopify.dev/docs/api/app-bridge),
/// [discount class](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations),
/// [function ID](https://shopify.dev/docs/apps/build/functions/input-output/metafields-for-input-queries),
/// and other metadata about the discount type, including the discount type's name and description.
/// </summary>
public record AppDiscountType : IGraphQLObject
{
    /// <summary>
    /// The name of the app extension that's providing the
    /// [discount type](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The [App Bridge configuration](https://shopify.dev/docs/api/app-bridge)
    /// for the [discount type](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("appBridge")]
    public FunctionsAppBridge? appBridge { get; set; } = null;

    /// <summary>
    /// The [client ID](https://shopify.dev/docs/apps/build/authentication-authorization/client-secrets)
    /// of the app extension that's providing the [discount type](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("appKey")]
    public string? appKey { get; set; } = null;

    /// <summary>
    /// A description of the
    /// [discount type](https://help.shopify.com/manual/discounts/discount-types)
    /// provided by the app extension.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The [discount class](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that's used to control how discounts can be combined.
    /// </summary>
    [JsonPropertyName("discountClass")]
    [Obsolete("Use `discountClasses` instead.")]
    public DiscountClass? discountClass { get; set; } = null;

    /// <summary>
    /// The list of [discount classes](https://help.shopify.com/manual/discounts/combining-discounts/discount-combinations)
    /// that this app extension supports.
    /// </summary>
    [JsonPropertyName("discountClasses")]
    public ICollection<DiscountClass>? discountClasses { get; set; } = null;

    /// <summary>
    /// The
    /// [function ID](https://shopify.dev/docs/apps/build/functions/input-output/metafields-for-input-queries)
    /// associated with the app extension providing the
    /// [discount type](https://help.shopify.com/manual/discounts/discount-types).
    /// </summary>
    [JsonPropertyName("functionId")]
    public string? functionId { get; set; } = null;

    /// <summary>
    /// The type of line item on an order that the
    /// [discount type](https://help.shopify.com/manual/discounts/discount-types) applies to.
    /// Valid values: `SHIPPING_LINE` and `LINE_ITEM`.
    /// </summary>
    [JsonPropertyName("targetType")]
    [Obsolete("Use `discountClasses` instead.")]
    public DiscountApplicationTargetType? targetType { get; set; } = null;

    /// <summary>
    /// The name of the [discount type](https://help.shopify.com/manual/discounts/discount-types)
    /// that the app extension is providing.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}