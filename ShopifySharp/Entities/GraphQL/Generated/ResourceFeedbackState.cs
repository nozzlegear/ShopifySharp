#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The state of the resource feedback.
/// </summary>
public enum ResourceFeedbackState
{
    ACCEPTED,
    REQUIRES_ACTION,
}