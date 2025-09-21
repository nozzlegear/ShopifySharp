#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible content types for a file object.
/// </summary>
public enum FileContentType
{
    IMAGE,
    FILE,
    VIDEO,
    EXTERNAL_VIDEO,
    MODEL_3D,
}