#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Current user's access policy for a finance app.
/// </summary>
public record FinanceAppAccessPolicy : IGraphQLObject
{
    /// <summary>
    /// Current shop staff's access within the app.
    /// </summary>
    [JsonPropertyName("access")]
    public ICollection<BankingFinanceAppAccess>? access { get; set; } = null;
}