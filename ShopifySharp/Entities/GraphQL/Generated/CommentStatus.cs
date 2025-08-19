#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The status of a comment.
/// </summary>
public enum CommentStatus
{
    SPAM,
    REMOVED,
    PUBLISHED,
    UNAPPROVED,
    PENDING,
}