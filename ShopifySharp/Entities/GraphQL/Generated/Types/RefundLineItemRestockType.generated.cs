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
/// The type of restock performed for a particular refund line item.
/// </summary>
public enum RefundLineItemRestockType
{
    RETURN,
    CANCEL,
    LEGACY_RESTOCK,
    NO_RESTOCK,
}