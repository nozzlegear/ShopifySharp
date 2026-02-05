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
/// How to calculate the parent product variant's price while bulk updating variant relationships.
/// </summary>
public enum PriceCalculationType
{
    COMPONENTS_SUM,
    FIXED,
    NONE,
}