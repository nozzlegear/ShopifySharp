#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Metafield access permissions for the Customer Account API.
/// </summary>
public enum MetafieldCustomerAccountAccessInput
{
    READ_WRITE,
    READ,
    NONE,
}