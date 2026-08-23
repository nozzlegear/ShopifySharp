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
/// The input fields for updating a market's shipping configuration.
/// </summary>
public record ShippingConfigurationUpdateInput : GraphQLInputObject<ShippingConfigurationUpdateInput>
{
    /// <summary>
    /// Whether shipping is enabled for this market. When false, customers in this
    /// market won't see shipping options at checkout. Defaults to true when the
    /// market has no shipping configuration; otherwise preserves the existing value.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public bool? isEnabled { get; set; } = null;

    /// <summary>
    /// Shipping options to create for this market.
    /// </summary>
    [JsonPropertyName("optionDefinitionsToCreate")]
    public ICollection<DeliveryOptionDefinitionCreateInput>? optionDefinitionsToCreate { get; set; } = null;

    /// <summary>
    /// The IDs of shipping options to remove.
    /// </summary>
    [JsonPropertyName("optionDefinitionsToDelete")]
    public ICollection<string>? optionDefinitionsToDelete { get; set; } = null;

    /// <summary>
    /// Shipping options to update, matched by ID.
    /// </summary>
    [JsonPropertyName("optionDefinitionsToUpdate")]
    public ICollection<DeliveryOptionDefinitionUpdateInput>? optionDefinitionsToUpdate { get; set; } = null;
}