#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible statuses for a media preview image.
/// </summary>
public enum MediaPreviewImageStatus
{
    UPLOADED,
    PROCESSING,
    READY,
    FAILED,
}