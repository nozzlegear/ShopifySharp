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
/// Tax settings for a customer.
/// </summary>
public record TaxSettings : IGraphQLObject
{
    /// <summary>
    /// The customer's tax ID.
    /// </summary>
    [JsonPropertyName("taxId")]
    public string? taxId { get; set; } = null;
}