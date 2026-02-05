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
/// The associated catalog's type.
/// </summary>
public enum CatalogType
{
    NONE,
    APP,
    COMPANY_LOCATION,
    MARKET,
}