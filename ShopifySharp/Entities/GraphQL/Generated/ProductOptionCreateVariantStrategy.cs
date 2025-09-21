#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The set of variant strategies available for use in the `productOptionsCreate` mutation.
/// </summary>
public enum ProductOptionCreateVariantStrategy
{
    LEAVE_AS_IS,
    CREATE,
}