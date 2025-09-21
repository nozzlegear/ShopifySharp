#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The method by which the discount's value is allocated onto its entitled lines.
/// </summary>
public enum DiscountApplicationAllocationMethod
{
    ACROSS,
    EACH,
    [Obsolete("Use ACROSS instead.")]
    ONE,
}