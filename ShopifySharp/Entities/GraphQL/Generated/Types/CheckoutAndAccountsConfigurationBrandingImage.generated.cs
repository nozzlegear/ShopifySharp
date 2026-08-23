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
/// The image.
/// </summary>
public record CheckoutAndAccountsConfigurationBrandingImage : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The image details.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;
}