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
/// Metaobject access permissions for the Admin API. When the metaobject is app-owned, the owning app always has
/// full access.
/// </summary>
public enum MetaobjectAdminAccessInput
{
    MERCHANT_READ,
    MERCHANT_READ_WRITE,
}