#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Host for a Media Resource.
/// </summary>
public enum MediaHost
{
    YOUTUBE,
    VIMEO,
}