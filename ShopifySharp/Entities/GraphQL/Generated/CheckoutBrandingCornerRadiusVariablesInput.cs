#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields used to update the corner radius variables.
/// </summary>
public record CheckoutBrandingCornerRadiusVariablesInput : GraphQLInputObject<CheckoutBrandingCornerRadiusVariablesInput>
{
    /// <summary>
    /// The value in pixels for base corner radii. It should be greater than zero. Example: 5.
    /// </summary>
    [JsonPropertyName("base")]
    public int? @base { get; set; } = null;

    /// <summary>
    /// The value in pixels for large corner radii. It should be greater than zero. Example: 10.
    /// </summary>
    [JsonPropertyName("large")]
    public int? large { get; set; } = null;

    /// <summary>
    /// The value in pixels for small corner radii. It should be greater than zero. Example: 3.
    /// </summary>
    [JsonPropertyName("small")]
    public int? small { get; set; } = null;
}