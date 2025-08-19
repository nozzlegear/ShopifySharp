#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `MenuDeleteUserError`.
/// </summary>
public enum MenuDeleteUserErrorCode
{
    MENU_DOES_NOT_EXIST,
    UNABLE_TO_DELETE_DEFAULT_MENU,
}