#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A shipping profile that defines shipping rates for specific
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) objects and [`ProductVariant`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant)
/// objects. Delivery profiles determine which products can ship from which
/// [`Location`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location)
/// objects to which zones, and at what rates.
/// Profiles can associate with [`SellingPlanGroup`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SellingPlanGroup)
/// objects to provide custom shipping rules for subscriptions, such as free
/// shipping or restricted delivery zones. The default profile applies to all
/// products that aren't assigned to other profiles.
/// Learn more about [building delivery profiles](https://shopify.dev/apps/build/purchase-options/deferred/delivery-and-deferment/build-delivery-profiles).
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
    [Obsolete("Legacy mode profiles are no longer supported. This will be removed in 2026-04.")]
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
    /// The version of the delivery profile.
    /// </summary>
    [JsonPropertyName("version")]
    public int? version { get; set; } = null;

    /// <summary>
    /// The number of countries with active rates to deliver to.
    /// </summary>
    [JsonPropertyName("zoneCountryCount")]
    public int? zoneCountryCount { get; set; } = null;
}