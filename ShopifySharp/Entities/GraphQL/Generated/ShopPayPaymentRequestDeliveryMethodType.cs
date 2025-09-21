#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the delivery method type for a Shop Pay payment request.
/// </summary>
public enum ShopPayPaymentRequestDeliveryMethodType
{
    SHIPPING,
    PICKUP,
}