#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Possible error codes that can be returned by `CommentApproveUserError`.
/// </summary>
public enum CommentApproveUserErrorCode
{
    NOT_FOUND,
}