#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Possible comment policies for a blog.
/// </summary>
public enum CommentPolicy
{
    AUTO_PUBLISHED,
    CLOSED,
    MODERATED,
}