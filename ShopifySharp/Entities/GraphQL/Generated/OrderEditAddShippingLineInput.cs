#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to add a shipping line.
/// </summary>
public record OrderEditAddShippingLineInput : GraphQLInputObject<OrderEditAddShippingLineInput>
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