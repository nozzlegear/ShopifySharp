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
/// The set of valid sort keys for the CheckoutProfile query.
/// </summary>
public enum CheckoutProfileSortKeys
{
    CREATED_AT,
    EDITED_AT,
    ID,
    IS_PUBLISHED,
    UPDATED_AT,
}