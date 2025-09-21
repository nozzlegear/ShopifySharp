#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `CarrierServiceCreateUserError`.
/// </summary>
public enum CarrierServiceCreateUserErrorCode
{
    CARRIER_SERVICE_CREATE_FAILED,
}