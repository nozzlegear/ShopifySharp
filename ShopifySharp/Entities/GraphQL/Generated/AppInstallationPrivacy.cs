#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The levels of privacy of an app installation.
/// </summary>
public enum AppInstallationPrivacy
{
    PUBLIC,
    PRIVATE,
}