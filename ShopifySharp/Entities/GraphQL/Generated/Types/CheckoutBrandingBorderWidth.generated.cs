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
/// The container border width.
/// </summary>
public enum CheckoutBrandingBorderWidth
{
    BASE,
    LARGE_100,
    LARGE_200,
    LARGE,
}