#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The intended audience for the order status page.
/// </summary>
public enum Audience
{
    CUSTOMERVIEW,
    MERCHANTVIEW,
}