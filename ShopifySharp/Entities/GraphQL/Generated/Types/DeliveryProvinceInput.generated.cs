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