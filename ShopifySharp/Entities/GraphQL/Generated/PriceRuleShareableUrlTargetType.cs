#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of page where a shareable price rule URL lands.
/// </summary>
public enum PriceRuleShareableUrlTargetType
{
    HOME,
    PRODUCT,
    COLLECTION,
}