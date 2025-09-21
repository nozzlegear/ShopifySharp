#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields that set access permissions for the definition's metafields.
/// </summary>
public record MetafieldAccessInput : GraphQLInputObject<MetafieldAccessInput>
{
    /// <summary>
    /// The access permitted on the Admin API.
    /// </summary>
    [JsonPropertyName("admin")]
    public MetafieldAdminAccessInput? admin { get; set; } = null;

    /// <summary>
    /// The access permitted on the Customer Account API.
    /// </summary>
    [JsonPropertyName("customerAccount")]
    public MetafieldCustomerAccountAccessInput? customerAccount { get; set; } = null;

    /// <summary>
    /// The access permitted on the Storefront API.
    /// </summary>
    [JsonPropertyName("storefront")]
    public MetafieldStorefrontAccessInput? storefront { get; set; } = null;
}