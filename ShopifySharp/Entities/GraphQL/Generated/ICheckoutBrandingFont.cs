#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A font.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CheckoutBrandingCustomFont), typeDiscriminator: "CheckoutBrandingCustomFont")]
[JsonDerivedType(typeof(CheckoutBrandingShopifyFont), typeDiscriminator: "CheckoutBrandingShopifyFont")]
public interface ICheckoutBrandingFont : IGraphQLObject
{
    /// <summary>
    /// The font sources.
    /// </summary>
    [JsonPropertyName("sources")]
    public string? sources { get; set; }

    /// <summary>
    /// The font weight.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? weight { get; set; }
}