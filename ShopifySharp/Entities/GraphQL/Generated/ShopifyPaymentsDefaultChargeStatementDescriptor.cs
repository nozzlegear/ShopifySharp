#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The charge descriptors for a payments account.
/// </summary>
public record ShopifyPaymentsDefaultChargeStatementDescriptor : IGraphQLObject, IShopifyPaymentsChargeStatementDescriptor
{
    /// <summary>
    /// The default charge statement descriptor.
    /// </summary>
    [JsonPropertyName("default")]
    public string? @default { get; set; } = null;

    /// <summary>
    /// The prefix of the statement descriptor.
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? prefix { get; set; } = null;
}