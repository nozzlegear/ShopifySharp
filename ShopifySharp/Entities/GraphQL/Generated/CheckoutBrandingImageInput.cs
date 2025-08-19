#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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