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
/// The supported units for gift card expiration.
/// </summary>
public enum GiftCardConfigurationExpirationUnit
{
    DAYS,
    MONTHS,
    YEARS,
}