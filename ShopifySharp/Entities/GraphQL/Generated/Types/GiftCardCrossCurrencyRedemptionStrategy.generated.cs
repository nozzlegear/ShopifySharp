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
/// The strategy used to convert the gift card's balance when it is redeemed in a currency other than the one it was issued in.
/// </summary>
public enum GiftCardCrossCurrencyRedemptionStrategy
{
    NONE,
    MARKET_FX,
    SPOT_FX,
}