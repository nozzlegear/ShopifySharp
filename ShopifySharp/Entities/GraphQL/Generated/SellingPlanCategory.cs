#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The category of the selling plan. For the `OTHER` category,
///          you must fill out our [request form](https://docs.google.com/forms/d/e/1FAIpQLSeU18Xmw0Q61V8wdH-dfGafFqIBfRchQKUO8WAF3yJTvgyyZQ/viewform),
///          where we'll review your request for a new purchase option.
/// </summary>
public enum SellingPlanCategory
{
    OTHER,
    PRE_ORDER,
    SUBSCRIPTION,
    TRY_BEFORE_YOU_BUY,
}