#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The set of valid sort keys for the ShipmentLineItem query.
/// </summary>
public enum ShipmentLineItemSortKeys
{
    ID,
}