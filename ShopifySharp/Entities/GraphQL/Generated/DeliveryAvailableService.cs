#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A shipping service and a list of countries that the service is available for.
/// </summary>
public record DeliveryAvailableService : IGraphQLObject
{
    /// <summary>
    /// The countries the service provider ships to.
    /// </summary>
    [JsonPropertyName("countries")]
    public DeliveryCountryCodesOrRestOfWorld? countries { get; set; } = null;

    /// <summary>
    /// The name of the service.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}