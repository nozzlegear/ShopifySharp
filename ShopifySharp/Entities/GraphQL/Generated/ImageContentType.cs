#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// List of supported image content types.
/// </summary>
public enum ImageContentType
{
    PNG,
    JPG,
    WEBP,
}