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
/// Whether a column was explicitly requested in the query or dynamically generated.
/// </summary>
public enum ShopifyqlColumnOrigin
{
    UNSPECIFIED,
    REQUESTED,
    GENERATED,
}