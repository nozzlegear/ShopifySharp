#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The purpose of a localized field.
/// </summary>
public enum LocalizedFieldPurpose
{
    SHIPPING,
    TAX,
}