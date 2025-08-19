#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record CommentEventEmbedCustomer(Customer Value): CommentEventEmbed;
internal record CommentEventEmbedDraftOrder(DraftOrder Value): CommentEventEmbed;
internal record CommentEventEmbedInventoryTransfer(InventoryTransfer Value): CommentEventEmbed;
internal record CommentEventEmbedOrder(Order Value): CommentEventEmbed;
internal record CommentEventEmbedProduct(Product Value): CommentEventEmbed;
internal record CommentEventEmbedProductVariant(ProductVariant Value): CommentEventEmbed;
#endif /// <summary>

/// The subject line of a comment event.
/// </summary>
public interface ICommentEventSubject : IGraphQLObject
{
    /// <summary>
    /// Whether the timeline subject has a timeline comment. If true, then a timeline comment exists.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }
}