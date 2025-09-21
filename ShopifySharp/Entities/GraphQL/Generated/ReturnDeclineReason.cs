#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The reason why the merchant declined a customer's return request.
/// </summary>
public enum ReturnDeclineReason
{
    RETURN_PERIOD_ENDED,
    FINAL_SALE,
    OTHER,
}