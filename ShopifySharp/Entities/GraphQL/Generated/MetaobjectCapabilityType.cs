#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Metaobject Capabilities types which can be enabled.
/// </summary>
public enum MetaobjectCapabilityType
{
    PUBLISHABLE,
    TRANSLATABLE,
    RENDERABLE,
    ONLINE_STORE,
}