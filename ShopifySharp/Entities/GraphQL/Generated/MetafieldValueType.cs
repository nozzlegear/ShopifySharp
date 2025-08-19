#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Legacy type information for the stored value.
/// Replaced by `type`.
/// </summary>
public enum MetafieldValueType
{
    STRING,
    INTEGER,
    JSON_STRING,
    BOOLEAN,
}