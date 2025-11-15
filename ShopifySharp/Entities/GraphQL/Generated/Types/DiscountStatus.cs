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
/// The status of the discount that describes its availability,
/// expiration, or pending activation.
/// </summary>
public enum DiscountStatus
{
    ACTIVE,
    EXPIRED,
    SCHEDULED,
}