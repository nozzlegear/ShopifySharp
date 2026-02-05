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
/// A response to a ShopifyQL query.
/// </summary>
public record ShopifyqlQueryResponse : IGraphQLObject
{
    /// <summary>
    /// A list of parse errors, if parsing fails.
    /// </summary>
    [JsonPropertyName("parseErrors")]
    public ICollection<string>? parseErrors { get; set; } = null;

    /// <summary>
    /// The result in a tabular format with column and row data.
    /// </summary>
    [JsonPropertyName("tableData")]
    public ShopifyqlTableData? tableData { get; set; } = null;
}