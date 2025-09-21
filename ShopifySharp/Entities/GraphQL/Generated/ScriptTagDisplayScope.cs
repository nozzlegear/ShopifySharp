#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The page or pages on the online store where the script should be included.
/// </summary>
public enum ScriptTagDisplayScope
{
    [Obsolete("`ALL` is deprecated. Use `ONLINE_STORE` instead. ")]
    ALL,
    [Obsolete("`ORDER_STATUS` is deprecated and unavailable as a mutation input. ")]
    ORDER_STATUS,
    ONLINE_STORE,
}