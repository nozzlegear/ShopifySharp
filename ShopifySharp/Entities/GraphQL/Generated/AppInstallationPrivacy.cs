#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The levels of privacy of an app installation.
/// </summary>
public enum AppInstallationPrivacy
{
    PUBLIC,
    PRIVATE,
}