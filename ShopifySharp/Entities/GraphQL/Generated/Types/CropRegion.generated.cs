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
/// The part of the image that should remain after cropping.
/// </summary>
public enum CropRegion
{
    CENTER,
    TOP,
    BOTTOM,
    LEFT,
    RIGHT,
}