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
/// The field type that the condition will be applied to.
/// </summary>
public enum DeliveryConditionField
{
    TOTAL_WEIGHT,
    TOTAL_PRICE,
}