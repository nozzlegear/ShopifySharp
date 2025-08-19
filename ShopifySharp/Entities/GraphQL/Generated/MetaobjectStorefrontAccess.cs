#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Metaobject access permissions for the Storefront API.
/// </summary>
public enum MetaobjectStorefrontAccess
{
    NONE,
    PUBLIC_READ,
}