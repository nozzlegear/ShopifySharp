#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to update a policy.
/// </summary>
public record ShopPolicyInput : GraphQLInputObject<ShopPolicyInput>
{
    /// <summary>
    /// Policy text, maximum size of 512kb.
    /// </summary>
    [JsonPropertyName("body")]
    public string? body { get; set; } = null;

    /// <summary>
    /// The shop policy type.
    /// </summary>
    [JsonPropertyName("type")]
    public ShopPolicyType? type { get; set; } = null;
}