#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible values for object fit.
/// </summary>
public enum CheckoutBrandingObjectFit
{
    CONTAIN,
    COVER,
}