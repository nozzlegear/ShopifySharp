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
/// Access permissions for the definition's metafields.
/// </summary>
public record MetafieldAccess : IGraphQLObject
{
    /// <summary>
    /// The access permitted on the Admin API.
    /// </summary>
    [JsonPropertyName("admin")]
    public MetafieldAdminAccess? admin { get; set; } = null;

    /// <summary>
    /// The access permitted on the Customer Account API.
    /// </summary>
    [JsonPropertyName("customerAccount")]
    public MetafieldCustomerAccountAccess? customerAccount { get; set; } = null;

    /// <summary>
    /// The access permitted on the Storefront API.
    /// </summary>
    [JsonPropertyName("storefront")]
    public MetafieldStorefrontAccess? storefront { get; set; } = null;
}