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
/// The shop's online store channel.
/// </summary>
public record OnlineStore : IGraphQLObject
{
    /// <summary>
    /// Storefront password information.
    /// </summary>
    [JsonPropertyName("passwordProtection")]
    public OnlineStorePasswordProtection? passwordProtection { get; set; } = null;
}