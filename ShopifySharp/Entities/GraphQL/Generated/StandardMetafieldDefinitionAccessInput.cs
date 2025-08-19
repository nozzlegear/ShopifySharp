#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the access settings for the metafields under the standard definition.
/// </summary>
public record StandardMetafieldDefinitionAccessInput : GraphQLInputObject<StandardMetafieldDefinitionAccessInput>
{
    /// <summary>
    /// The Admin API access setting to use for the metafields under this definition.
    /// </summary>
    [JsonPropertyName("admin")]
    public MetafieldAdminAccessInput? admin { get; set; } = null;

    /// <summary>
    /// The Customer Account API access setting to use for the metafields under this definition.
    /// </summary>
    [JsonPropertyName("customerAccount")]
    public MetafieldCustomerAccountAccessInput? customerAccount { get; set; } = null;

    /// <summary>
    /// The Storefront API access setting to use for the metafields under this definition.
    /// </summary>
    [JsonPropertyName("storefront")]
    public MetafieldStorefrontAccessInput? storefront { get; set; } = null;
}