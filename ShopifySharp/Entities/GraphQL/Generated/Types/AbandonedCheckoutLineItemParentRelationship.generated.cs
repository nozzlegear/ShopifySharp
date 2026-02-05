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
/// The line relationship between two line items in an abandoned checkout.
/// </summary>
public record AbandonedCheckoutLineItemParentRelationship : IGraphQLObject
{
    /// <summary>
    /// The parent line item of the current line item.
    /// </summary>
    [JsonPropertyName("parent")]
    public AbandonedCheckoutLineItem? parent { get; set; } = null;
}