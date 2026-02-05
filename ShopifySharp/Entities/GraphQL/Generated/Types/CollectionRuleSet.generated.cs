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
/// The set of rules that are used to determine which products are included in the collection.
/// </summary>
public record CollectionRuleSet : IGraphQLObject
{
    /// <summary>
    /// Whether products must match any or all of the rules to be included in the collection.
    /// If true, then products must match at least one of the rules to be included in the collection.
    /// If false, then products must match all of the rules to be included in the collection.
    /// </summary>
    [JsonPropertyName("appliedDisjunctively")]
    public bool? appliedDisjunctively { get; set; } = null;

    /// <summary>
    /// The rules used to assign products to the collection.
    /// </summary>
    [JsonPropertyName("rules")]
    public ICollection<CollectionRule>? rules { get; set; } = null;
}