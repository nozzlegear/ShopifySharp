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
/// The input fields for customizing the image.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingImageInput : GraphQLInputObject<CheckoutAndAccountsConfigurationBrandingImageInput>
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("mediaImageId")]
    public string? mediaImageId { get; set; } = null;
}