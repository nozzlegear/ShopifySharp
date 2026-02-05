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
/// Metaobject Capabilities types which can be enabled.
/// </summary>
public enum MetaobjectCapabilityType
{
    PUBLISHABLE,
    TRANSLATABLE,
    RENDERABLE,
    ONLINE_STORE,
}