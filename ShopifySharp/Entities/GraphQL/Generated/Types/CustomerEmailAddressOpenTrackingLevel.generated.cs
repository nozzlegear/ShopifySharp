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
/// The different levels related to whether a customer has opted in to having their opened emails tracked.
/// </summary>
public enum CustomerEmailAddressOpenTrackingLevel
{
    UNKNOWN,
    OPTED_IN,
    OPTED_OUT,
}