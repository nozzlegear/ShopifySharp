#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the context data that determines the pricing of a variant. Refer to [Product](https://shopify.dev/docs/api/admin-graphql/latest/queries/product?example=Get+the+price+range+for+a+product+for+buyers+from+Canada)for
/// more information on how to use this input object.
/// </summary>
public record ContextualPricingContext : GraphQLInputObject<ContextualPricingContext>
{
    /// <summary>
    /// The CompanyLocation ID used to fetch company location specific prices.
    /// </summary>
    [JsonPropertyName("companyLocationId")]
    public string? companyLocationId { get; set; } = null;

    /// <summary>
    /// The country code used to fetch country-specific prices.
    /// </summary>
    [JsonPropertyName("country")]
    public CountryCode? country { get; set; } = null;

    /// <summary>
    /// The Location ID used to fetch location specific prices.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;
}