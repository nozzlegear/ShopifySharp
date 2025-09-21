#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Metafield access permissions for the Customer Account API.
/// </summary>
public enum MetafieldCustomerAccountAccess
{
    READ_WRITE,
    READ,
    NONE,
}