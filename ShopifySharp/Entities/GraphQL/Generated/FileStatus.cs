#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible statuses for a file object.
/// </summary>
public enum FileStatus
{
    UPLOADED,
    PROCESSING,
    READY,
    FAILED,
}