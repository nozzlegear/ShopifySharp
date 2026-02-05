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
/// A discount application removed during an order edit.
/// </summary>
public record OrderStagedChangeRemoveDiscount : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The removed discount application.
    /// </summary>
    [JsonPropertyName("discountApplication")]
    public IDiscountApplication? discountApplication { get; set; } = null;
}