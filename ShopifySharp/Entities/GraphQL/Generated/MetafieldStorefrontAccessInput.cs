#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Metafield access permissions for the Storefront API.
/// </summary>
public enum MetafieldStorefrontAccessInput
{
    PUBLIC_READ,
    NONE,
}