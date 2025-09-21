#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The possible categories of an app installation, based on their purpose
/// or the environment they can run in.
/// </summary>
public enum AppInstallationCategory
{
    CHANNEL,
    POS_EMBEDDED,
}