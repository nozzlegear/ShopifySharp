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
/// Answers the question if prices include duties and / or taxes.
/// </summary>
public enum InclusiveDutiesPricingStrategy
{
    ADD_DUTIES_AT_CHECKOUT,
    INCLUDE_DUTIES_IN_PRICE,
}