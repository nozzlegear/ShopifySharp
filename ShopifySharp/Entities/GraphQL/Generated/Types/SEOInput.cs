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
/// The input fields for SEO information.
/// </summary>
public record SEOInput : GraphQLInputObject<SEOInput>
{
    /// <summary>
    /// SEO description of the product.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// SEO title of the product.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}