#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible order action types for a
/// [sales agreement](https://shopify.dev/api/admin-graphql/latest/interfaces/salesagreement).
/// </summary>
public enum OrderActionType
{
    ORDER,
    ORDER_EDIT,
    REFUND,
    RETURN,
    UNKNOWN,
}