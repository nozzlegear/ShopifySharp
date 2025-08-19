#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Warning types for media.
/// </summary>
public enum MediaWarningCode
{
    MODEL_SMALL_PHYSICAL_SIZE,
    MODEL_LARGE_PHYSICAL_SIZE,
    MODEL_PREVIEW_IMAGE_FAIL,
}