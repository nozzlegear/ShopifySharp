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
/// The footer content customizations.
/// </summary>
public record CheckoutBrandingFooterContent : IGraphQLObject
{
    /// <summary>
    /// The visibility settings for footer content.
    /// </summary>
    [JsonPropertyName("visibility")]
    public CheckoutBrandingVisibility? visibility { get; set; } = null;
}