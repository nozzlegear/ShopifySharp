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
/// The input fields for line items that the discount refers to.
/// </summary>
public record SubscriptionManualDiscountLinesInput : GraphQLInputObject<SubscriptionManualDiscountLinesInput>
{
    /// <summary>
    /// The ID of the lines to add to the subscription discount.
    /// </summary>
    [JsonPropertyName("add")]
    public ICollection<string>? @add { get; set; } = null;

    /// <summary>
    /// The ID of the lines to remove from the subscription discount.
    /// </summary>
    [JsonPropertyName("remove")]
    public ICollection<string>? @remove { get; set; } = null;
}