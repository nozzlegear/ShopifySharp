#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The set of valid sort keys for the DraftOrder query.
/// </summary>
public enum DraftOrderSortKeys
{
    CUSTOMER_NAME,
    ID,
    NUMBER,
    RELEVANCE,
    STATUS,
    TOTAL_PRICE,
    UPDATED_AT,
}