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
/// The input fields to create and update a delivery customization.
/// </summary>
public record DeliveryCustomizationInput : GraphQLInputObject<DeliveryCustomizationInput>
{
    /// <summary>
    /// The enabled status of the delivery customization.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// Function handle scoped to your current app ID. Only finds functions within your app.
    /// </summary>
    [JsonPropertyName("functionHandle")]
    public string? functionHandle { get; set; } = null;

    /// <summary>
    /// Additional metafields to associate to the delivery customization.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The title of the delivery customization.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}