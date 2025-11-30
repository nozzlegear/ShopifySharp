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
/// A method definition contains the delivery rate and the conditions that must be met for the method to be
/// applied.
/// </summary>
public record DeliveryMethodDefinition : IGraphQLObject, INode
{
    /// <summary>
    /// Whether this method definition is active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool? active { get; set; } = null;

    /// <summary>
    /// The description of the method definition. Only available on shipping rates that are custom.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The method conditions that must pass for this method definition to be applied to an order.
    /// </summary>
    [JsonPropertyName("methodConditions")]
    public ICollection<DeliveryCondition>? methodConditions { get; set; } = null;

    /// <summary>
    /// The name of the method definition.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The provided rate for this method definition, from a rate definition or participant.
    /// </summary>
    [JsonPropertyName("rateProvider")]
    public DeliveryRateProvider? rateProvider { get; set; } = null;
}