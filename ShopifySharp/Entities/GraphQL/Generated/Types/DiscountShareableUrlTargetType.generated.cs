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
/// The type of page where a shareable discount URL lands.
/// </summary>
public enum DiscountShareableUrlTargetType
{
    HOME,
    PRODUCT,
    COLLECTION,
}