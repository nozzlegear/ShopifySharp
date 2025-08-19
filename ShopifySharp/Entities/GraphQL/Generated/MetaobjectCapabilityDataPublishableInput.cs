#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for publishable capability to adjust visibility on channels.
/// </summary>
public record MetaobjectCapabilityDataPublishableInput : GraphQLInputObject<MetaobjectCapabilityDataPublishableInput>
{
    /// <summary>
    /// The visibility status of this metaobject across all channels.
    /// </summary>
    [JsonPropertyName("status")]
    public MetaobjectStatus? status { get; set; } = null;
}