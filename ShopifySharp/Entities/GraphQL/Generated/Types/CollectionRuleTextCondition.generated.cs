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
/// Specifies the condition for a text field.
/// </summary>
public record CollectionRuleTextCondition : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The value of the condition.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}