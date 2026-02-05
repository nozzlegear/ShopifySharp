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
/// Represents customer segments that are eligible to receive a specific discount,
/// allowing merchants to target promotions to defined groups of customers. This
/// enables personalized marketing campaigns based on customer behavior and
/// characteristics.
/// For example, a "VIP Customer 15% Off" promotion might target a segment of
/// high-value repeat customers, while a "New Customer Welcome" discount could focus
/// on first-time buyers.
/// Segment-based discounts help merchants create more relevant promotional
/// experiences and improve conversion rates by showing the right offers to the
/// right customers at the right time.
/// </summary>
public record DiscountCustomerSegments : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The list of customer segments who are eligible for the discount.
    /// </summary>
    [JsonPropertyName("segments")]
    public ICollection<Segment>? segments { get; set; } = null;
}