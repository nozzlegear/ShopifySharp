#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to update a shipping line.
/// </summary>
public record OrderEditUpdateShippingLineInput : GraphQLInputObject<OrderEditUpdateShippingLineInput>
{
    /// <summary>
    /// The price of the shipping line.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyInput? price { get; set; } = null;

    /// <summary>
    /// The title of the shipping line.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}