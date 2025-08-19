#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents information about the purchasing company for the order or draft order.
/// </summary>
public record PurchasingCompany : PurchasingEntity, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The company associated to the order or draft order.
    /// </summary>
    [JsonPropertyName("company")]
    public Company? company { get; set; } = null;

    /// <summary>
    /// The company contact associated to the order or draft order.
    /// </summary>
    [JsonPropertyName("contact")]
    public CompanyContact? contact { get; set; } = null;

    /// <summary>
    /// The company location associated to the order or draft order.
    /// </summary>
    [JsonPropertyName("location")]
    public CompanyLocation? location { get; set; } = null;
}