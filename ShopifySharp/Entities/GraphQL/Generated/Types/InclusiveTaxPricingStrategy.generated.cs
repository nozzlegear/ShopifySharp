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
public enum InclusiveTaxPricingStrategy
{
    ADD_TAXES_AT_CHECKOUT,
    INCLUDES_TAXES_IN_PRICE,
    INCLUDES_TAXES_IN_PRICE_BASED_ON_COUNTRY,
}