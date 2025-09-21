#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The billing plan of the shop.
/// </summary>
public record ShopPlan : IGraphQLObject
{
    /// <summary>
    /// The name of the shop's billing plan.
    /// </summary>
    [JsonPropertyName("displayName")]
    [Obsolete("Use `publicDisplayName` instead.")]
    public string? displayName { get; set; } = null;

    /// <summary>
    /// Whether the shop is a partner development shop for testing purposes.
    /// </summary>
    [JsonPropertyName("partnerDevelopment")]
    public bool? partnerDevelopment { get; set; } = null;

    /// <summary>
    /// The public display name of the shop's billing plan. Possible values are:
    /// Advanced, Basic, Development, Grow, Inactive, Lite, Other, Paused, Plus, Plus
    /// Trial, Retail, Shop Component, Staff Business, Starter, and Trial.
    /// </summary>
    [JsonPropertyName("publicDisplayName")]
    public string? publicDisplayName { get; set; } = null;

    /// <summary>
    /// Whether the shop has a Shopify Plus subscription.
    /// </summary>
    [JsonPropertyName("shopifyPlus")]
    public bool? shopifyPlus { get; set; } = null;
}