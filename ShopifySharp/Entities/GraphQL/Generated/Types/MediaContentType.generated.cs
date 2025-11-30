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
/// The possible content types for a media object.
/// </summary>
public enum MediaContentType
{
    VIDEO,
    EXTERNAL_VIDEO,
    MODEL_3D,
    IMAGE,
}