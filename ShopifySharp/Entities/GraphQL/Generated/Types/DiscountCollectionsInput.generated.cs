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
/// The input fields for collections attached to a discount.
/// </summary>
public record DiscountCollectionsInput : GraphQLInputObject<DiscountCollectionsInput>
{
    /// <summary>
    /// Specifies list of collection ids to add.
    /// </summary>
    [JsonPropertyName("add")]
    public ICollection<string>? @add { get; set; } = null;

    /// <summary>
    /// Specifies list of collection ids to remove.
    /// </summary>
    [JsonPropertyName("remove")]
    public ICollection<string>? @remove { get; set; } = null;
}