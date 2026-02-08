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
/// The input fields for resource association with a Selling Plan Group.
/// </summary>
public record SellingPlanGroupResourceInput : GraphQLInputObject<SellingPlanGroupResourceInput>
{
    /// <summary>
    /// The IDs of the Products to add to the Selling Plan Group.
    /// </summary>
    [JsonPropertyName("productIds")]
    public ICollection<string>? productIds { get; set; } = null;

    /// <summary>
    /// The IDs of the Variants to add to the Selling Plan Group.
    /// </summary>
    [JsonPropertyName("productVariantIds")]
    public ICollection<string>? productVariantIds { get; set; } = null;
}