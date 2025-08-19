#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A additional cost, charged by the merchant, on an order. Examples include return shipping fees and restocking fees.
/// </summary>
public interface IFee : IGraphQLObject
{
    /// <summary>
    /// The unique ID for the Fee.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }
}