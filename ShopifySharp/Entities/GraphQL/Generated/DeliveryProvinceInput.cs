#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to specify a region.
/// </summary>
public record DeliveryProvinceInput : GraphQLInputObject<DeliveryProvinceInput>
{
    /// <summary>
    /// The code of the region.
    /// </summary>
    [JsonPropertyName("code")]
    public string? code { get; set; } = null;
}