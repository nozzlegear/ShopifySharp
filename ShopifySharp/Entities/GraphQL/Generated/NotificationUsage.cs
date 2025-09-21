#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The valid values for the notification usage, specifying the intended notification environment usage for certain operations.
/// </summary>
public enum NotificationUsage
{
    WEB,
    SMS,
}