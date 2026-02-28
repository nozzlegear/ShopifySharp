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
/// The result of a ShopifyQL query.
/// </summary>
public record ShopifyqlTableData : IGraphQLObject
{
    /// <summary>
    /// The columns of the table.
    /// </summary>
    [JsonPropertyName("columns")]
    public ICollection<ShopifyqlTableDataColumn>? columns { get; set; } = null;

    /// <summary>
    /// The rows of the table.
    /// </summary>
    [JsonPropertyName("rows")]
    public string? rows { get; set; } = null;
}