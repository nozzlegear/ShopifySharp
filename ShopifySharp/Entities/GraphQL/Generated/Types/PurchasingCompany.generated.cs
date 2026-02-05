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
/// Represents information about the purchasing company for the order or draft order.
/// </summary>
public record PurchasingCompany : IGraphQLUnionCase, IGraphQLObject
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