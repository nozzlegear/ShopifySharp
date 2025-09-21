#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A calculated return.
/// </summary>
public record CalculatedReturn : IGraphQLObject
{
    /// <summary>
    /// A list of calculated exchange line items.
    /// </summary>
    [JsonPropertyName("exchangeLineItems")]
    public ICollection<CalculatedExchangeLineItem>? exchangeLineItems { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A list of calculated return line items.
    /// </summary>
    [JsonPropertyName("returnLineItems")]
    public ICollection<CalculatedReturnLineItem>? returnLineItems { get; set; } = null;

    /// <summary>
    /// The calculated return shipping fee.
    /// </summary>
    [JsonPropertyName("returnShippingFee")]
    public CalculatedReturnShippingFee? returnShippingFee { get; set; } = null;
}