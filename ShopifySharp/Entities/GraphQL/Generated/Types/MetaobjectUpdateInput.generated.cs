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
/// The input fields for updating a metaobject.
/// </summary>
public record MetaobjectUpdateInput : GraphQLInputObject<MetaobjectUpdateInput>
{
    /// <summary>
    /// Capabilities for the metaobject.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public MetaobjectCapabilityDataInput? capabilities { get; set; } = null;

    /// <summary>
    /// Values for fields. These are mapped by key to fields of the metaobject definition.
    /// </summary>
    [JsonPropertyName("fields")]
    public ICollection<MetaobjectFieldInput>? fields { get; set; } = null;

    /// <summary>
    /// A unique handle for the metaobject.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Whether to create a redirect for the metaobject.
    /// </summary>
    [JsonPropertyName("redirectNewHandle")]
    public bool? redirectNewHandle { get; set; } = null;

    /// <summary>
    /// The field values for the metaobject as a JSON object, keyed by field
    /// definition key. This is a full replacement — omitted keys are cleared on an
    /// existing record. Cannot be used in conjunction with `fields`.
    /// </summary>
    [JsonPropertyName("values")]
    public string? values { get; set; } = null;
}