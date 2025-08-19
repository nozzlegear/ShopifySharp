#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The associated catalog's type.
/// </summary>
public enum CatalogType
{
    NONE,
    APP,
    COMPANY_LOCATION,
    MARKET,
}