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
/// Return type for `cashManagementReasonCodeCreate` mutation.
/// </summary>
public record CashManagementReasonCodeCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created cash management reason code.
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public CashManagementCustomReasonCode? reasonCode { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CashManagementReasonCodeCreateUserError>? userErrors { get; set; } = null;
}