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
/// The input fields that set access permissions for the definition's metaobjects.
/// </summary>
public record MetaobjectAccessInput : GraphQLInputObject<MetaobjectAccessInput>
{
    /// <summary>
    /// The access permitted on the Admin API.
    /// </summary>
    [JsonPropertyName("admin")]
    public MetaobjectAdminAccessInput? admin { get; set; } = null;

    /// <summary>
    /// The access permitted on the Customer Account API.
    /// </summary>
    [JsonPropertyName("customerAccount")]
    public MetaobjectCustomerAccountAccess? customerAccount { get; set; } = null;

    /// <summary>
    /// The access permitted on the Storefront API.
    /// </summary>
    [JsonPropertyName("storefront")]
    public MetaobjectStorefrontAccess? storefront { get; set; } = null;
}