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
/// The input fields used to update a checkout branding image uploaded via the Files API.
/// </summary>
public record CheckoutBrandingImageInput : GraphQLInputObject<CheckoutBrandingImageInput>
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("mediaImageId")]
    public string? mediaImageId { get; set; } = null;
}