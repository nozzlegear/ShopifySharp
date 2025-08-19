#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Information about the shop's customer accounts.
/// </summary>
public record CustomerAccountsV2 : IGraphQLObject
{
    /// <summary>
    /// Indicates which version of customer accounts the merchant is using in online store and checkout.
    /// </summary>
    [JsonPropertyName("customerAccountsVersion")]
    public CustomerAccountsVersion? customerAccountsVersion { get; set; } = null;

    /// <summary>
    /// Login links are shown in online store and checkout.
    /// </summary>
    [JsonPropertyName("loginLinksVisibleOnStorefrontAndCheckout")]
    public bool? loginLinksVisibleOnStorefrontAndCheckout { get; set; } = null;

    /// <summary>
    /// Customers are required to log in to their account before checkout.
    /// </summary>
    [JsonPropertyName("loginRequiredAtCheckout")]
    public bool? loginRequiredAtCheckout { get; set; } = null;

    /// <summary>
    /// The root url for the customer accounts pages.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}