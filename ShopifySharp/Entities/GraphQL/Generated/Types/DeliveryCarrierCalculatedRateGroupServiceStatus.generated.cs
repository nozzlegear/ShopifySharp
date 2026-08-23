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
/// Whether a carrier-provided service is included at checkout.
/// </summary>
public enum DeliveryCarrierCalculatedRateGroupServiceStatus
{
    INCLUDED,
    EXCLUDED,
}