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
/// Represents a percentage price adjustment type.
/// </summary>
public enum PriceListAdjustmentType
{
    PERCENTAGE_DECREASE,
    PERCENTAGE_INCREASE,
}