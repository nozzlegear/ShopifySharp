#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `MenuDeleteUserError`.
/// </summary>
public enum MenuDeleteUserErrorCode
{
    MENU_DOES_NOT_EXIST,
    UNABLE_TO_DELETE_DEFAULT_MENU,
}