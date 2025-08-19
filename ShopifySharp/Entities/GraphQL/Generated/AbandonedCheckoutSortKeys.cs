#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of valid sort keys for the AbandonedCheckout query.
/// </summary>
public enum AbandonedCheckoutSortKeys
{
    CHECKOUT_ID,
    CREATED_AT,
    CUSTOMER_NAME,
    ID,
    RELEVANCE,
    TOTAL_PRICE,
}