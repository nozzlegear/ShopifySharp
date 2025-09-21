#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a rule set of the collection.
/// </summary>
public record CollectionRuleSetInput : GraphQLInputObject<CollectionRuleSetInput>
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
    public ICollection<CollectionRuleInput>? rules { get; set; } = null;
}