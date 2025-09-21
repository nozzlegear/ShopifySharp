#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible statuses for a media object.
/// </summary>
public enum MediaStatus
{
    UPLOADED,
    PROCESSING,
    READY,
    FAILED,
}