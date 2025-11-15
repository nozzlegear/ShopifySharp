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
/// Provides a field definition and the data value assigned to it.
/// </summary>
public record MetaobjectField : IGraphQLObject
{
    /// <summary>
    /// The field definition for this object key.
    /// </summary>
    [JsonPropertyName("definition")]
    public MetaobjectFieldDefinition? definition { get; set; } = null;

    /// <summary>
    /// The assigned field value in JSON format.
    /// </summary>
    [JsonPropertyName("jsonValue")]
    public string? jsonValue { get; set; } = null;

    /// <summary>
    /// The object key of this field.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// For resource reference fields, provides the referenced object.
    /// </summary>
    [JsonPropertyName("reference")]
    public MetafieldReference? reference { get; set; } = null;

    /// <summary>
    /// For resource reference list fields, provides the list of referenced objects.
    /// </summary>
    [JsonPropertyName("references")]
    public MetafieldReferenceConnection? references { get; set; } = null;

    /// <summary>
    /// For file reference or color fields, provides visual attributes for this field.
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public MetaobjectThumbnail? thumbnail { get; set; } = null;

    /// <summary>
    /// The type of the field.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;

    /// <summary>
    /// The assigned field value, always stored as a string regardless of the field type.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}