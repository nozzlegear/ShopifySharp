#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The role of the theme.
/// </summary>
public enum ThemeRole
{
    MAIN,
    UNPUBLISHED,
    DEMO,
    DEVELOPMENT,
    ARCHIVED,
    LOCKED,
    [Obsolete("The feature for this role has been deprecated.")]
    MOBILE,
}