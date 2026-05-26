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
/// Return type for `cashManagementReasonCodeDelete` mutation.
/// </summary>
public record CashManagementReasonCodeDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The deleted cash management reason code gid.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CashManagementReasonCodeDeleteUserError>? userErrors { get; set; } = null;
}