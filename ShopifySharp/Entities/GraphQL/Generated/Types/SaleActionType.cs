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
/// The possible order action types for a sale.
/// </summary>
public enum SaleActionType
{
    ORDER,
    RETURN,
    UPDATE,
    UNKNOWN,
}