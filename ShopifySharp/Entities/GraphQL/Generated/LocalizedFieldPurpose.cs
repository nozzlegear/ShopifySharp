#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The purpose of a localized field.
/// </summary>
public enum LocalizedFieldPurpose
{
    SHIPPING,
    TAX,
}