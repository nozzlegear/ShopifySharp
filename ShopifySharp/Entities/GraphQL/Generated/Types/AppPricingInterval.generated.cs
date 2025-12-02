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
/// The frequency at which the shop is billed for an app subscription.
/// </summary>
public enum AppPricingInterval
{
    ANNUAL,
    EVERY_30_DAYS,
}