#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type of resources that are market localizable.
/// </summary>
public enum MarketLocalizableResourceType
{
    METAFIELD,
    METAOBJECT,
}