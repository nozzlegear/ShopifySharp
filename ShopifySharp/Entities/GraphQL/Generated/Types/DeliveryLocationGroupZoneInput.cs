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
/// The input fields for a delivery zone associated to a location group and profile.
/// </summary>
public record DeliveryLocationGroupZoneInput : GraphQLInputObject<DeliveryLocationGroupZoneInput>
{
    /// <summary>
    /// A list of countries to associate with the zone.
    /// </summary>
    [JsonPropertyName("countries")]
    public ICollection<DeliveryCountryInput>? countries { get; set; } = null;

    /// <summary>
    /// A globally-unique ID of the zone.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A list of method definitions to create.
    /// </summary>
    [JsonPropertyName("methodDefinitionsToCreate")]
    public ICollection<DeliveryMethodDefinitionInput>? methodDefinitionsToCreate { get; set; } = null;

    /// <summary>
    /// A list of method definitions to update.
    /// </summary>
    [JsonPropertyName("methodDefinitionsToUpdate")]
    public ICollection<DeliveryMethodDefinitionInput>? methodDefinitionsToUpdate { get; set; } = null;

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}