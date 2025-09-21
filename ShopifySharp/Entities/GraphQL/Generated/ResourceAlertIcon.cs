#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The available icons for resource alerts.
/// </summary>
public enum ResourceAlertIcon
{
    CHECKMARK_CIRCLE,
    INFORMATION_CIRCLE,
}