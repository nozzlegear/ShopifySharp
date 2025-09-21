#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The context data that determines the publication status of a product.
/// </summary>
public record ContextualPublicationContext : GraphQLInputObject<ContextualPublicationContext>
{
    /// <summary>
    /// The company location ID used to fetch company-specific publication.
    /// </summary>
    [JsonPropertyName("companyLocationId")]
    public string? companyLocationId { get; set; } = null;

    /// <summary>
    /// The country code used to fetch country-specific publication.
    /// </summary>
    [JsonPropertyName("country")]
    public CountryCode? country { get; set; } = null;

    /// <summary>
    /// The Location ID used to fetch the publication status of a product.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;
}