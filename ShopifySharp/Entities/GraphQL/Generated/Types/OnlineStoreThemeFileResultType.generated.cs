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
/// Type of a theme file operation result.
/// </summary>
public enum OnlineStoreThemeFileResultType
{
    SUCCESS,
    ERROR,
    CONFLICT,
    UNPROCESSABLE_ENTITY,
    BAD_REQUEST,
    TIMEOUT,
    NOT_FOUND,
}