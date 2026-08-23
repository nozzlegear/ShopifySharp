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
/// An unrecognized customer selection type. Use the `context` field on the parent discount type instead.
/// </summary>
public record DiscountCustomerSelectionUnknown : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The underlying customer selection type.
    /// </summary>
    [JsonPropertyName("customerSelectionType")]
    public string? customerSelectionType { get; set; } = null;
}