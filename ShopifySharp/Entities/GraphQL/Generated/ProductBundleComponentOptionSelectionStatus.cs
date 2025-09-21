#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The status of a component option value related to a bundle.
/// </summary>
public enum ProductBundleComponentOptionSelectionStatus
{
    SELECTED,
    DESELECTED,
    NEW,
    UNAVAILABLE,
}