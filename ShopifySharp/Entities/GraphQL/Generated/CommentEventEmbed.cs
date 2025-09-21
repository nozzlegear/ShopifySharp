#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The main embed of a comment event.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<CommentEventEmbed>))]
public record CommentEventEmbed : GraphQLObject<CommentEventEmbed>, IGraphQLUnionType
{
    public Customer? AsCustomer() => this is CommentEventEmbedCustomer wrapper ? wrapper.Value : null;
    public DraftOrder? AsDraftOrder() => this is CommentEventEmbedDraftOrder wrapper ? wrapper.Value : null;
    public InventoryTransfer? AsInventoryTransfer() => this is CommentEventEmbedInventoryTransfer wrapper ? wrapper.Value : null;
    public Order? AsOrder() => this is CommentEventEmbedOrder wrapper ? wrapper.Value : null;
    public Product? AsProduct() => this is CommentEventEmbedProduct wrapper ? wrapper.Value : null;
    public ProductVariant? AsProductVariant() => this is CommentEventEmbedProductVariant wrapper ? wrapper.Value : null;
}