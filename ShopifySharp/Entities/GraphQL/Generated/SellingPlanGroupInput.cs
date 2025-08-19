#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to create or update a selling plan group.
/// </summary>
public record SellingPlanGroupInput : GraphQLInputObject<SellingPlanGroupInput>
{
    /// <summary>
    /// ID for app, exposed in Liquid and product JSON.
    /// </summary>
    [JsonPropertyName("appId")]
    public string? appId { get; set; } = null;

    /// <summary>
    /// Merchant facing description of the selling plan group.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// Merchant facing label of the selling plan group.
    /// </summary>
    [JsonPropertyName("merchantCode")]
    public string? merchantCode { get; set; } = null;

    /// <summary>
    /// Buyer facing label of the selling plan group.
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
    /// Relative value for display purposes of the selling plan group. A lower position will be displayed before a higher one.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// List of selling plans to create.
    /// </summary>
    [JsonPropertyName("sellingPlansToCreate")]
    public ICollection<SellingPlanInput>? sellingPlansToCreate { get; set; } = null;

    /// <summary>
    /// List of selling plans ids to delete.
    /// </summary>
    [JsonPropertyName("sellingPlansToDelete")]
    public ICollection<string>? sellingPlansToDelete { get; set; } = null;

    /// <summary>
    /// List of selling plans to update.
    /// </summary>
    [JsonPropertyName("sellingPlansToUpdate")]
    public ICollection<SellingPlanInput>? sellingPlansToUpdate { get; set; } = null;
}