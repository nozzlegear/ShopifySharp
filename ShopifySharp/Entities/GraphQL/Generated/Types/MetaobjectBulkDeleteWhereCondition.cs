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
/// Specifies the condition by which metaobjects are deleted.
/// Exactly one field of input is required.
/// </summary>
public record MetaobjectBulkDeleteWhereCondition : GraphQLInputObject<MetaobjectBulkDeleteWhereCondition>
{
    /// <summary>
    /// A list of metaobjects IDs to delete.
    /// </summary>
    [JsonPropertyName("ids")]
    public ICollection<string>? ids { get; set; } = null;

    /// <summary>
    /// Deletes all metaobjects with the specified `type`.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;
}