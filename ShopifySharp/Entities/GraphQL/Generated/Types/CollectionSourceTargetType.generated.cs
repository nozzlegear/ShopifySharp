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
/// Conditions that target variants cause either the entire product to be included when satisfied or only the matching variants.
/// </summary>
public enum CollectionSourceTargetType
{
    PRODUCTS,
    VARIANTS,
}