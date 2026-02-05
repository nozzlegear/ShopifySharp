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
/// Represents how the compare at price will be determined for a price list.
/// </summary>
public enum PriceListCompareAtMode
{
    ADJUSTED,
    NULLIFY,
}