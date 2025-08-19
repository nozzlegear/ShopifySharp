#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Metafield access permissions for the Admin API.
/// </summary>
public enum MetafieldAdminAccess
{
    PRIVATE,
    PUBLIC_READ,
    PUBLIC_READ_WRITE,
    MERCHANT_READ,
    MERCHANT_READ_WRITE,
}