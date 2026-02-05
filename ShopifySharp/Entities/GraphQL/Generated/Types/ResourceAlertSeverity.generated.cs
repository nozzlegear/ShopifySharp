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