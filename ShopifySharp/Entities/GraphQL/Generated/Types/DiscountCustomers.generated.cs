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
/// A list of individual customers eligible for the discount.
/// </summary>
public record DiscountCustomers : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The list of individual customers eligible for the discount.
    /// </summary>
    [JsonPropertyName("customers")]
    public ICollection<Customer>? customers { get; set; } = null;
}