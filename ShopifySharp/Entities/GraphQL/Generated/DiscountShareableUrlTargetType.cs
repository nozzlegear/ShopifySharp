#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of page where a shareable discount URL lands.
/// </summary>
public enum DiscountShareableUrlTargetType
{
    HOME,
    PRODUCT,
    COLLECTION,
}