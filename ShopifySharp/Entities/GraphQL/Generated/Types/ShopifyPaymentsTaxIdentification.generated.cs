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
/// A typed identifier that represents an individual within a tax jurisdiction.
/// </summary>
public record ShopifyPaymentsTaxIdentification : IGraphQLObject
{
    /// <summary>
    /// The type of the identification.
    /// </summary>
    [JsonPropertyName("taxIdentificationType")]
    public ShopifyPaymentsTaxIdentificationType? taxIdentificationType { get; set; } = null;

    /// <summary>
    /// The value of the identification.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}