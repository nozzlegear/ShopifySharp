#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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