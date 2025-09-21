#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible error codes that can be returned by `CommentDeleteUserError`.
/// </summary>
public enum CommentDeleteUserErrorCode
{
    NOT_FOUND,
}