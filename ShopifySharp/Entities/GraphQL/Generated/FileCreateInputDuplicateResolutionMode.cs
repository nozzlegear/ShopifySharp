#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for handling if filename is already in use.
/// </summary>
public enum FileCreateInputDuplicateResolutionMode
{
    APPEND_UUID,
    RAISE_ERROR,
    REPLACE,
}