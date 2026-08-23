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
/// Possible error codes that can be returned by `PointOfSaleDeviceAssignToCashDrawerUserError`.
/// </summary>
public enum PointOfSaleDeviceAssignToCashDrawerUserErrorCode
{
    INTERNAL_ERROR,
    LOCATION_MISMATCH,
    CASH_DRAWER_NOT_FOUND,
    POINT_OF_SALE_DEVICE_NOT_FOUND,
}