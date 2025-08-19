#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A shipping profile. In Shopify, a shipping profile is a set of shipping rates
/// scoped to a set of products or variants that can be shipped from selected
/// locations to zones. Learn more about [building with delivery profiles](https://shopify.dev/apps/build/purchase-options/deferred/delivery-and-deferment/build-delivery-profiles).
/// </summary>
public record DeliveryProfile : IGraphQLObject, INode
{
    /// <summary>
    /// The number of active shipping rates for the profile.
    /// </summary>
    [JsonPropertyName("activeMethodDefinitionsCount")]
    public int? activeMethodDefinitionsCount { get; set; } = null;

    /// <summary>
    /// Whether this is the default profile.
    /// </summary>
    [JsonPropertyName("default")]
    public bool? @default { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Whether this shop has enabled legacy compatibility mode for delivery profiles.
    /// </summary>
    [JsonPropertyName("legacyMode")]
    public bool? legacyMode { get; set; } = null;

    /// <summary>
    /// The number of locations without rates defined.
    /// </summary>
    [JsonPropertyName("locationsWithoutRatesCount")]
    public int? locationsWithoutRatesCount { get; set; } = null;

    /// <summary>
    /// The name of the delivery profile.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The number of active origin locations for the profile.
    /// </summary>
    [JsonPropertyName("originLocationCount")]
    public int? originLocationCount { get; set; } = null;

    /// <summary>
    /// How many product variants are in this profile.
    /// </summary>
    [JsonPropertyName("productVariantsCount")]
    public Count? productVariantsCount { get; set; } = null;

    /// <summary>
    /// How many product variants are in this profile.
    /// </summary>
    [JsonPropertyName("productVariantsCountV2")]
    [Obsolete("Use `productVariantsCount` instead.")]
    public DeliveryProductVariantsCount? productVariantsCountV2 { get; set; } = null;

    /// <summary>
    /// The products and variants associated with this profile.
    /// </summary>
    [JsonPropertyName("profileItems")]
    public DeliveryProfileItemConnection? profileItems { get; set; } = null;

    /// <summary>
    /// The location groups and associated zones using this profile.
    /// </summary>
    [JsonPropertyName("profileLocationGroups")]
    public ICollection<DeliveryProfileLocationGroup>? profileLocationGroups { get; set; } = null;

    /// <summary>
    /// Selling plan groups associated with the specified delivery profile.
    /// </summary>
    [JsonPropertyName("sellingPlanGroups")]
    public SellingPlanGroupConnection? sellingPlanGroups { get; set; } = null;

    /// <summary>
    /// List of locations that haven't been assigned to a location group for this profile.
    /// </summary>
    [JsonPropertyName("unassignedLocations")]
    public ICollection<Location>? unassignedLocations { get; set; } = null;

    /// <summary>
    /// List of locations that have not been assigned to a location group for this profile.
    /// </summary>
    [JsonPropertyName("unassignedLocationsPaginated")]
    public LocationConnection? unassignedLocationsPaginated { get; set; } = null;

    /// <summary>
    /// The number of countries with active rates to deliver to.
    /// </summary>
    [JsonPropertyName("zoneCountryCount")]
    public int? zoneCountryCount { get; set; } = null;
}