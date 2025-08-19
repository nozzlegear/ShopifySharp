#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An alert message that appears in the Shopify admin about a problem with a store
/// setting, with an action to take. For example, you could show an alert to ask the
/// merchant to enter their billing information to activate Shopify Plus.
/// </summary>
public record ShopAlert : IGraphQLObject
{
    /// <summary>
    /// The text for the button in the alert that links to related information. For example, _Add credit card_.
    /// </summary>
    [JsonPropertyName("action")]
    public ShopAlertAction? action { get; set; } = null;

    /// <summary>
    /// A description of the alert and further information, such as whether the merchant will be charged.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;
}