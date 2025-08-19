#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Defines visibility status for metaobjects.
/// </summary>
public enum MetaobjectStatus
{
    DRAFT,
    ACTIVE,
}