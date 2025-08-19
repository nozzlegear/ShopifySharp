#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to create or update a selling plan.
/// </summary>
public record SellingPlanInput : GraphQLInputObject<SellingPlanInput>
{
    /// <summary>
    /// Selling plan policy which describes the billing details.
    /// </summary>
    [JsonPropertyName("billingPolicy")]
    public SellingPlanBillingPolicyInput? billingPolicy { get; set; } = null;

    /// <summary>
    /// The category used to classify this selling plan for reporting purposes.
    /// </summary>
    [JsonPropertyName("category")]
    public SellingPlanCategory? category { get; set; } = null;

    /// <summary>
    /// A selling plan policy which describes the delivery details.
    /// </summary>
    [JsonPropertyName("deliveryPolicy")]
    public SellingPlanDeliveryPolicyInput? deliveryPolicy { get; set; } = null;

    /// <summary>
    /// Buyer facing string which describes the selling plan commitment.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// ID of the selling plan.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A selling plan policy which describes the inventory details.
    /// </summary>
    [JsonPropertyName("inventoryPolicy")]
    public SellingPlanInventoryPolicyInput? inventoryPolicy { get; set; } = null;

    /// <summary>
    /// Additional customizable information to associate with the SellingPlan.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// Buyer facing string which describes the selling plan content.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The values of all options available on the selling plan. Selling plans are
    /// grouped together in Liquid when they're created by the same app, and have the
    /// same `selling_plan_group.name` and `selling_plan_group.options` values.
    /// </summary>
    [JsonPropertyName("options")]
    public ICollection<string>? options { get; set; } = null;

    /// <summary>
    /// Relative value for display purposes of this plan. A lower position will be displayed before a higher one.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// The pricing policies which describe the pricing details. Each selling plan
    /// can only contain a maximum of 2 pricing policies.
    /// </summary>
    [JsonPropertyName("pricingPolicies")]
    public ICollection<SellingPlanPricingPolicyInput>? pricingPolicies { get; set; } = null;
}