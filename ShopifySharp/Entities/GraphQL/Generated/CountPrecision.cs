#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The precision of the value returned by a count field.
/// </summary>
public enum CountPrecision
{
    EXACT,
    AT_LEAST,
}