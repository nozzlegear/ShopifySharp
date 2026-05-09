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
/// The status of the point of sale device payment session. Payments can't be
/// processed or refunded during a closed session, and the cash drawer balance can't
/// be adjusted or corrected.
/// </summary>
public enum PointOfSaleDevicePaymentSessionStatus
{
    OPEN,
    CLOSED,
}