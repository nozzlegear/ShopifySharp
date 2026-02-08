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
/// Metafield access permissions for the Customer Account API.
/// </summary>
public enum MetafieldCustomerAccountAccessInput
{
    READ_WRITE,
    READ,
    NONE,
}