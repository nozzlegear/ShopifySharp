#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The possible severity levels for a resource alert.
/// </summary>
public enum ResourceAlertSeverity
{
    DEFAULT,
    INFO,
    WARNING,
    SUCCESS,
    CRITICAL,
    [Obsolete("`ERROR` severity is being deprecated in favour of `WARNING` or `CRITICAL` instead.")]
    ERROR,
}