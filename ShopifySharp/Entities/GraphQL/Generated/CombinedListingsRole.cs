#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The role of the combined listing.
/// </summary>
public enum CombinedListingsRole
{
    PARENT,
    CHILD,
}