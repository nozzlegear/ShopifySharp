#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible content types for a media object.
/// </summary>
public enum MediaContentType
{
    VIDEO,
    EXTERNAL_VIDEO,
    MODEL_3D,
    IMAGE,
}