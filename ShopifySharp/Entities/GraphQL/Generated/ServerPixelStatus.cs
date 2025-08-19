#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The current state of a server pixel.
/// </summary>
public enum ServerPixelStatus
{
    CONNECTED,
    DISCONNECTED_UNCONFIGURED,
    DISCONNECTED_CONFIGURED,
}