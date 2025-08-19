#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible order action types for a sale.
/// </summary>
public enum SaleActionType
{
    ORDER,
    RETURN,
    UPDATE,
    UNKNOWN,
}