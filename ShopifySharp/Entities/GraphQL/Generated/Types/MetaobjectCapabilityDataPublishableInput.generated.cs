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