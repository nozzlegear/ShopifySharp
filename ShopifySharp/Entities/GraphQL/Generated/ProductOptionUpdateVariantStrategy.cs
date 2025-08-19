#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The set of variant strategies available for use in the `productOptionUpdate` mutation.
/// </summary>
public enum ProductOptionUpdateVariantStrategy
{
    LEAVE_AS_IS,
    MANAGE,
}