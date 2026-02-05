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
/// Return type for `marketingActivityUpsertExternal` mutation.
/// </summary>
public record MarketingActivityUpsertExternalPayload : IGraphQLObject
{
    /// <summary>
    /// The external marketing activity that was created or updated.
    /// </summary>
    [JsonPropertyName("marketingActivity")]
    public MarketingActivity? marketingActivity { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<MarketingActivityUserError>? userErrors { get; set; } = null;
}