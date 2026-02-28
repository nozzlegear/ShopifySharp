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
/// Return type for `orderEditAddVariant` mutation.
/// </summary>
public record OrderEditAddVariantPayload : IGraphQLObject
{
    /// <summary>
    /// The [calculated line item](https://shopify.dev/api/admin-graphql/latest/objects/calculatedlineitem)
    /// that's added during this order edit.
    /// </summary>
    [JsonPropertyName("calculatedLineItem")]
    public CalculatedLineItem? calculatedLineItem { get; set; } = null;

    /// <summary>
    /// The [calculated order](https://shopify.dev/api/admin-graphql/latest/objects/calculatedorder)
    /// with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("calculatedOrder")]
    public CalculatedOrder? calculatedOrder { get; set; } = null;

    /// <summary>
    /// The order edit session with the edits applied but not saved.
    /// </summary>
    [JsonPropertyName("orderEditSession")]
    public OrderEditSession? orderEditSession { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}