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
/// The set of valid sort keys for the Order query.
/// </summary>
public enum OrderSortKeys
{
    CREATED_AT,
    CURRENT_TOTAL_PRICE,
    CUSTOMER_NAME,
    DESTINATION,
    FINANCIAL_STATUS,
    FULFILLMENT_STATUS,
    ID,
    ORDER_NUMBER,
    PO_NUMBER,
    PROCESSED_AT,
    RELEVANCE,
    TOTAL_ITEMS_QUANTITY,
    TOTAL_PRICE,
    UPDATED_AT,
}