#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Metafield access permissions for the Admin API.
/// </summary>
public enum MetafieldAdminAccessInput
{
    MERCHANT_READ,
    MERCHANT_READ_WRITE,
}