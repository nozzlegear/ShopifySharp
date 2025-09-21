#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a buyer signal.
/// </summary>
public record BuyerSignalInput : GraphQLInputObject<BuyerSignalInput>
{
    /// <summary>
    /// The country code of the buyer.
    /// </summary>
    [JsonPropertyName("countryCode")]
    public CountryCode? countryCode { get; set; } = null;
}