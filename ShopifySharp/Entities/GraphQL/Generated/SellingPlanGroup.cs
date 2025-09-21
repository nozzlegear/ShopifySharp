#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a selling method (for example, "Subscribe and save" or "Pre-paid"). Selling plan groups
/// and associated records (selling plans and policies) are deleted 48 hours after a merchant
/// uninstalls their subscriptions app. We recommend backing up these records if you need to restore them later.
/// </summary>
public record SellingPlanGroup : IGraphQLObject, IHasPublishedTranslations, INode
{
    /// <summary>
    /// The ID for app, exposed in Liquid and product JSON.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? appId { get; set; } = null;

    /// <summary>
    /// Whether the given product is directly associated to the selling plan group.
    /// </summary>
    [JsonPropertyName("appliesToProduct")]
    public bool? appliesToProduct { get; set; } = null;

    /// <summary>
    /// Whether the given product variant is directly associated to the selling plan group.
    /// </summary>
    [JsonPropertyName("appliesToProductVariant")]
    public bool? appliesToProductVariant { get; set; } = null;

    /// <summary>
    /// Whether any of the product variants of the given product are associated to the selling plan group.
    /// </summary>
    [JsonPropertyName("appliesToProductVariants")]
    public bool? appliesToProductVariants { get; set; } = null;

    /// <summary>
    /// The date and time when the selling plan group was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The merchant-facing description of the selling plan group.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The merchant-facing label of the selling plan group.
    /// </summary>
    [JsonPropertyName("merchantCode")]
    public string? merchantCode { get; set; } = null;

    /// <summary>
    /// The buyer-facing label of the selling plan group.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The values of all options available on the selling plan group. Selling plans
    /// are grouped together in Liquid when they're created by the same app, and have
    /// the same `selling_plan_group.name` and `selling_plan_group.options` values.
    /// </summary>
    [JsonPropertyName("options")]
    public ICollection<string>? options { get; set; } = null;

    /// <summary>
    /// The relative position of the selling plan group for display.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// Products associated to the selling plan group.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// A count of products associated to the selling plan group.
    /// </summary>
    [JsonPropertyName("productsCount")]
    public Count? productsCount { get; set; } = null;

    /// <summary>
    /// Product variants associated to the selling plan group.
    /// </summary>
    [JsonPropertyName("productVariants")]
    public ProductVariantConnection? productVariants { get; set; } = null;

    /// <summary>
    /// A count of product variants associated to the selling plan group.
    /// </summary>
    [JsonPropertyName("productVariantsCount")]
    public Count? productVariantsCount { get; set; } = null;

    /// <summary>
    /// Selling plans associated to the selling plan group.
    /// </summary>
    [JsonPropertyName("sellingPlans")]
    public SellingPlanConnection? sellingPlans { get; set; } = null;

    /// <summary>
    /// A summary of the policies associated to the selling plan group.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? summary { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;
}