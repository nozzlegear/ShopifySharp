#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the access settings for the metafields under the definition.
/// </summary>
public record MetafieldAccessUpdateInput : GraphQLInputObject<MetafieldAccessUpdateInput>
{
    /// <summary>
    /// The admin access setting to use for the metafields under this definition.
    /// </summary>
    [JsonPropertyName("admin")]
    public MetafieldAdminAccessInput? admin { get; set; } = null;

    /// <summary>
    /// The Customer Account API access setting to use for the metafields under this definition.
    /// </summary>
    [JsonPropertyName("customerAccount")]
    public MetafieldCustomerAccountAccessInput? customerAccount { get; set; } = null;

    /// <summary>
    /// The storefront access setting to use for the metafields under this definition.
    /// </summary>
    [JsonPropertyName("storefront")]
    public MetafieldStorefrontAccessInput? storefront { get; set; } = null;
}