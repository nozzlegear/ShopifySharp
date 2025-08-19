#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A shop's data sale opt out page.
/// </summary>
public record DataSaleOptOutPage : IGraphQLObject
{
    /// <summary>
    /// If the data sale opt out page is auto managed.
    /// </summary>
    [JsonPropertyName("autoManaged")]
    public bool? autoManaged { get; set; } = null;
}