#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Specifies the email state.
/// </summary>
public enum AbandonmentEmailState
{
    NOT_SENT,
    SENT,
    SCHEDULED,
}