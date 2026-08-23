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
/// The input fields for date and time range filter.
/// </summary>
public record CashDrawerDateRangeInput : GraphQLInputObject<CashDrawerDateRangeInput>
{
    /// <summary>
    /// The start of the date and time range.
    /// </summary>
    [JsonPropertyName("from")]
    public DateTimeOffset? @from { get; set; } = null;

    /// <summary>
    /// The end of the date and time range.
    /// </summary>
    [JsonPropertyName("to")]
    public DateTimeOffset? to { get; set; } = null;
}