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
/// Default reason code.
/// </summary>
public record CashManagementDefaultReasonCode : IGraphQLUnionCase, IGraphQLObject, INode
{
    /// <summary>
    /// The code for the default reason code.
    /// </summary>
    [JsonPropertyName("code")]
    public CashManagementDefaultReasonCodeEnum? code { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}