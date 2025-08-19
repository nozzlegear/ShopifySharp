#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The state of the resource feedback.
/// </summary>
public enum ResourceFeedbackState
{
    ACCEPTED,
    REQUIRES_ACTION,
}