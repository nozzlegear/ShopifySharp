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
/// Return type for `marketingActivityCreate` mutation.
/// </summary>
public record MarketingActivityCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created marketing activity.
    /// </summary>
    [JsonPropertyName("marketingActivity")]
    [Obsolete("Marketing activity app extensions are deprecated and will be removed in the near future.")]
    public MarketingActivity? marketingActivity { get; set; } = null;

    /// <summary>
    /// The path to return back to shopify admin from embedded editor.
    /// </summary>
    [JsonPropertyName("redirectPath")]
    [Obsolete("Marketing activity app extensions are deprecated and will be removed in the near future.")]
    public string? redirectPath { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}