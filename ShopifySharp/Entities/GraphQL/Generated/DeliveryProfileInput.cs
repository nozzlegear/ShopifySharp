#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a delivery profile.
/// </summary>
public record DeliveryProfileInput : GraphQLInputObject<DeliveryProfileInput>
{
    /// <summary>
    /// The list of condition IDs to delete.
    /// </summary>
    [JsonPropertyName("conditionsToDelete")]
    public ICollection<string>? conditionsToDelete { get; set; } = null;

    /// <summary>
    /// The list of location groups to be created in the delivery profile.
    /// **Note:** due to the potential complexity of the nested data, it is
    /// recommended to send no more than 5 location groups per each request.
    /// </summary>
    [JsonPropertyName("locationGroupsToCreate")]
    public ICollection<DeliveryProfileLocationGroupInput>? locationGroupsToCreate { get; set; } = null;

    /// <summary>
    /// The list of location groups to be deleted from the delivery profile.
    /// </summary>
    [JsonPropertyName("locationGroupsToDelete")]
    public ICollection<string>? locationGroupsToDelete { get; set; } = null;

    /// <summary>
    /// The list of location groups to be updated in the delivery profile.
    /// **Note:** due to the potential complexity of the nested data, it is
    /// recommended to send no more than 5 location groups per each request.
    /// </summary>
    [JsonPropertyName("locationGroupsToUpdate")]
    public ICollection<DeliveryProfileLocationGroupInput>? locationGroupsToUpdate { get; set; } = null;

    /// <summary>
    /// The list of method definition IDs to delete.
    /// </summary>
    [JsonPropertyName("methodDefinitionsToDelete")]
    public ICollection<string>? methodDefinitionsToDelete { get; set; } = null;

    /// <summary>
    /// The name of the delivery profile.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The list of location groups associated with the delivery profile.
    /// </summary>
    [JsonPropertyName("profileLocationGroups")]
    public ICollection<DeliveryProfileLocationGroupInput>? profileLocationGroups { get; set; } = null;

    /// <summary>
    /// The list of selling plan groups to be associated with the delivery profile.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupsToAssociate")]
    public ICollection<string>? sellingPlanGroupsToAssociate { get; set; } = null;

    /// <summary>
    /// The list of selling plan groups to be dissociated with the delivery profile.
    /// </summary>
    [JsonPropertyName("sellingPlanGroupsToDissociate")]
    public ICollection<string>? sellingPlanGroupsToDissociate { get; set; } = null;

    /// <summary>
    /// The list of product variant IDs to be associated with the delivery profile.
    /// </summary>
    [JsonPropertyName("variantsToAssociate")]
    public ICollection<string>? variantsToAssociate { get; set; } = null;

    /// <summary>
    /// The list of product variant IDs to be dissociated from the delivery profile.
    /// The dissociated product variants are moved back to the default delivery profile.
    /// </summary>
    [JsonPropertyName("variantsToDissociate")]
    public ICollection<string>? variantsToDissociate { get; set; } = null;

    /// <summary>
    /// The list of zone IDs to delete.
    /// </summary>
    [JsonPropertyName("zonesToDelete")]
    public ICollection<string>? zonesToDelete { get; set; } = null;
}